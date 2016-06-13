﻿using Free.Dolphin.Common;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Free.Dolphin.Core
{
    public class RedisContext
    {

        private RedisContext()
        {

        }

        static Dictionary<Type, RedisDynamicMethodEmit> _tableCache = new Dictionary<Type, RedisDynamicMethodEmit>();
        static Dictionary<Type, RedisDynamicMethodEmit> _rankCache = new Dictionary<Type, RedisDynamicMethodEmit>();
        public static RedisContext GlobalContext { get; private set; }

        protected static ConnectionMultiplexer RedisConnection { get; private set; }

        protected static IDatabase RedisDb { get; private set; }
        public static void InitRedisContext(string redisConnectionString, Assembly assembly)
        {
            InitEntity(assembly);

            RedisConnection = ConnectionMultiplexer.Connect(redisConnectionString);

            RedisDb = RedisConnection.GetDatabase();
            GlobalContext = new RedisContext();
        }

        private static void InitEntity(Assembly assembly)
        {
            foreach (var row in assembly.GetTypes())
            {
                RedisTableAttribute rt = row.GetCustomAttribute<RedisTableAttribute>();
                if (rt != null)
                {
                    if (!_tableCache.ContainsKey(row))
                    {
                        foreach (var propertie in row.GetProperties())
                        {
                            RedisColumnAttribute redisColumn = propertie.GetCustomAttribute<RedisColumnAttribute>();
                            if (redisColumn != null && redisColumn.ColumnType == RedisColumnType.RedisKey)
                            {
                                _tableCache.Add(row,
                                new RedisDynamicMethodEmit(
                                     RedisDynamicMethodEmit.CreatePropertyGetter(propertie),
                                     RedisDynamicMethodEmit.CreatePropertySetter(propertie),
                                     redisColumn.ColumnType
                                     ));
                            }
                            if (redisColumn != null && redisColumn.ColumnType == RedisColumnType.RedisScore)
                            {
                                _rankCache.Add(row, new RedisDynamicMethodEmit(
                                     RedisDynamicMethodEmit.CreatePropertyGetter(propertie),
                                     RedisDynamicMethodEmit.CreatePropertySetter(propertie),
                                     redisColumn.ColumnType
                                     ));
                            }
                        }
                    }
                }
            }
        }


        //TODO: 修改序列化的方式
        public async void AddHashEntityAsync(object entity)
        {
            await Task.Run(() =>
            {
                Type t = entity.GetType();
                var key = _tableCache[t].GetValue(entity).ToString();

                RedisDb.HashSet(t.Name, new HashEntry[] {
                new HashEntry(key, SerializerUtil.BinarySerialize(entity))
            });
            });
        }
        public void AddHashEntity(object entity)
        {
            Type t = entity.GetType();
            var key = _tableCache[t].GetValue(entity).ToString();

            RedisDb.HashSet(t.Name, new HashEntry[] {
                new HashEntry(key, SerializerUtil.BinarySerialize(entity))
            });
        }

        public long IncrHashEntity(object entity)
        {
            Type t = entity.GetType();
            var key = _tableCache[t].GetValue(entity).ToString();
            return RedisDb.HashIncrement(t.Name, key);
        }

        public T FindHashEntityByKey<T>(string key)
        {
            return (T)SerializerUtil.BinaryDeserialize(RedisDb.HashGet(typeof(T).Name, key));
        }

        public IEnumerable<T> FindEntityAll<T>()
        {
            Task<HashEntry[]> task = RedisDb.HashGetAllAsync(typeof(T).Name);
            Task.WaitAll(task);
            foreach (var row in task.Result)
            {
                yield return (T)SerializerUtil.BinaryDeserialize(row.Value);
            }
        }


        public void AddSortedSetEntity(object entity)
        {
            Type t = entity.GetType();
            var key = _tableCache[t].GetValue(entity).ToString();
            var score = (int)_rankCache[t].GetValue(entity);
            RedisDb.SortedSetAdd(t.Name, key, score);
        }

        public void DeleteHashEntity(object entity)
        {
            Type t = entity.GetType();
            var key = _tableCache[t].GetValue(entity).ToString();
            RedisDb.HashDelete(t.Name, key);
        }

        public void DeleteSortedSetEntity(object entity)
        {
            Type t = entity.GetType();
            var key = _tableCache[t].GetValue(entity).ToString();
            RedisDb.SortedSetRemove(t.Name, key);
        }
    }
}
