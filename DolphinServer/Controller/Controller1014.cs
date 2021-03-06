﻿using DolphinServer.Entity;
using DolphinServer.ProtoEntity;
using DolphinServer.Service.Mj;
using Free.Dolphin.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolphinServer.Controller
{
    /// <summary>
    /// 捉炮
    /// </summary>
    [ControllerProtocol((int)ControllerType.Controller1014)]
    [ControllerAuth]
    public class Controller1014 : ControllerBase
    {
        public Controller1014(ControllerContext context) : base(context)
        {
        }

        public override byte[] ProcessAction()
        {
            int roomId = int.Parse(Context.HttpQueryString["RoomID"]);
            int huType = int.Parse(Context.HttpQueryString["HuType"]);
            int card = int.Parse(Context.HttpQueryString["Card"]);
            int card1 = Context.HttpQueryString.ContainsKey("Card1") ? int.Parse(Context.HttpQueryString["Card1"]) : -1;
            string desUid = Context.HttpQueryString["DesUid"];
            CsMjGameRoom room = CsGameRoomManager.GetRoomById(roomId);
            room.ZhuoPao(Context.Session.User.Uid, desUid, huType, card, card1);
            return null;
        }
    }
}
