﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Free.Dolphin.Core
{
    public interface IGameUser
    {
        string Uid { get; set; }
        string Pwd { get; set; }
        Guid Sid { get; set; }
        DateTime OnlimeDate { get; set; }
        GameUserState UserState { get; set; }

        String NickName { get; set; }

        IGameUser Login(string uid,string pwd);

    }
}
