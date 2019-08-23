﻿namespace ThePalace.Core.Enums
{
    public enum EventTypes : uint
    {
        MSG_GMSG = 0x676D7367,
        MSG_SMSG = 0x736D7367,
        MSG_RMSG = 0x726D7367,
        MSG_WMSG = 0x776D7367,
        MSG_SERVERDOWN = 0x646F776E,
        MSG_SERVERUP = 0x696E6974,
        MSG_SERVERINFO = 0x73696E66,
        MSG_LOGON = 0x72656769,
        MSG_ALTLOGONREPLY = 0x72657032,
        MSG_LOGOFF = 0x62796520,
        MSG_VERSION = 0x76657273,
        MSG_DIYIT = 0x72796974,
        MSG_TIYID = 0x74697972,
        MSG_PING = 0x70696E67,
        MSG_PONG = 0x706F6E67,
        MSG_TALK = 0x74616C6B,
        MSG_WHISPER = 0x77686973,
        MSG_XTALK = 0x78746C6B,
        MSG_XWHISPER = 0x78776973,
        MSG_DRAW = 0x64726177,
        MSG_USERNEW = 0x6E707273,
        MSG_USERLOG = 0x6C6F6720,
        MSG_USERMOVE = 0x754C6F63,
        MSG_USERCOLOR = 0x75737243,
        MSG_USERFACE = 0x75737246,
        MSG_USERNAME = 0x7573724E,
        MSG_USERENTER = 0x77707273,
        MSG_USEREXIT = 0x65707273,
        MSG_USERLIST = 0x72707273,
        MSG_USERPROP = 0x75737250,
        MSG_USERDESC = 0x75737244,
        MSG_ROOMNEW = 0x6E526F6D,
        MSG_ROOMGOTO = 0x6E617652,
        MSG_ROOMSETDESC = 0x73526F6D,
        MSG_ROOMDESC = 0x726F6F6D,
        MSG_ROOMDESCEND = 0x656E6472,
        MSG_LISTOFALLROOMS = 0x724C7374,
        MSG_LISTOFALLUSERS = 0x754C7374,
        MSG_DOORLOCK = 0x6C6F636B,
        MSG_DOORUNLOCK = 0x756E6C6F,
        MSG_SPOTSTATE = 0x73537461,
        MSG_ASSETNEW = 0x61417374,
        MSG_ASSETSEND = 0x73417374,
        MSG_AUTHENTICATE = 0x61757468,
        MSG_AUTHRESPONSE = 0x61757472,
        MSG_HTTPSERVER = 0x48545450,
        MSG_ASSETREGI = 0x72417374,
        MSG_ASSETQUERY = 0x71417374,
        MSG_FILEQUERY = 0x7146696C,
        MSG_FILESEND = 0x7346696C,
        MSG_FILENOTFND = 0x666e6665,
        MSG_PROPNEW = 0x6E507270,
        MSG_PROPMOVE = 0x6D507270,
        MSG_PROPDEL = 0x64507270,
        MSG_PROPSETDESC = 0x73507270,
        MSG_SPOTNEW = 0x6F70536E,
        MSG_SPOTMOVE = 0x636F4C73,
        MSG_SPOTDEL = 0x6F705364,
        MSG_SPOTSETDESC = 0x6F705373,
        MSG_PICTNEW = 0x6E506374,
        MSG_PICTMOVE = 0x704C6F63,
        MSG_PICTDEL = 0x46505371,
        MSG_PICTSETDESC = 0x73506374,
        MSG_SUPERUSER = 0x73757372,
        MSG_KILLUSER = 0x6B696C6C,
        MSG_INITCONNECTION = 0x634C6F67,
        MSG_USERSTATUS = 0x75537461,
        MSG_BLOWTHRU = 0x626C6F77,
        MSG_NAVERROR = 0x73457272,
        MSG_EXTENDEDINFO = 0x73496e66,
    };
}
