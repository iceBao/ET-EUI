namespace ET
{
    public static partial class ErrorCode
    {
        public const int ERR_Success = 0;

        // 1-11004 是SocketError请看SocketError定义
        //-----------------------------------
        // 100000-109999是Core层的错误
        
        // 110000以下的错误请看ErrorCore.cs
        
        // 这里配置逻辑层的错误码
        // 110000 - 200000是抛异常的错误
        // 200001以上不抛异常
        
        public const int ERR_NetWorkError = 200002; //网络错误
        public const int ERR_LoginInfoError = 200003; //登录信息醋五哦
        public const int ERR_AccountNameFormError = 200004; //登录账号格式错误
        public const int ERR_PasswordFormError = 200005; //登录密码格式错误
        public const int ERR_AccountInBlackList = 200006; //账号处于黑名单
        public const int ERR_LoginPasswordError = 200007; //登录密码错误
        public const int ERR_RequestRepeatedly = 200008; //重复请求
        public const int ERR_TokenError = 200009; // token错误

        public const int ERR_RoleNameIsNull = 200010; //游戏角色名空
        public const int ERR_RoleNameSame = 200011; // 游戏角色名相同
        public const int ERR_RoleNotExist = 200012; // 游戏角色不存在
        
        public const int ERR_RequestGateTokenError = 200013; // 请求gate令牌错误
        public const int ERR_RequestSceneTypeError = 200014; // 请求scene错误
        public const int ERR_ConnectGateKeyError = 200015; // 连接Gate的key错误
        public const int ERR_OtherAccountLogin = 200016; // 其他账号连接
        public const int ERR_SessionPlayerError = 200017; // 获取sessionplayer错误
        public const int ERR_NonePlayerError = 200018; // 未获取到playeer
        public const int ERR_SessionStateError = 200019; // Session状态错误
        public const int ERR_EnterGameError = 200020; // 进入游戏逻辑服错误
        public const int ERR_ReEnterGameError = 200021; // 二次进入游戏服失败
        public const int ERR_ReEnterGameError2 = 200022; // 二次进入游戏服失败2



    }
}