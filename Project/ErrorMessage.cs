namespace Project
{
    public static class ErrorMessage
    {
        //Public
        public const string UnauthorizedException = "操作失败，未验证";
        public const string InternalServerError = "服务器内部错误，请联系管理员";
        public const string UserLoginFault = "用户名或密码不正确";
        public const string AuthenticationTokenMissing = "Token无效或者已过期";
        public const string UserIsNotExist = "当前用户不存在";
        public const string ResetPasswordTokenIsNotNull = "重置密码Token错误";
        public const string ResetPasswordTokenMissing = "重置密码Token错误";
        public const string ResetPasswordTokenExpired = "重置密码Token过期";
        public const string ResetPasswordFault = "重置密码失败";
        public const string OldPasswordError = "旧密码错误";
        public const string ChangePasswordFault = "修改密码失败";
        public const string AuthenticationTokenExpired = "Token无效或者已过期";
        public const string UserWasDisabled = "用户已停用，无法登录，如需登录请联系管理员";
        public const string AbsenceIsNotExist = "Absence不存在";
        public const string MonthlyIsNotExist = "月报不存在";
        public const string CurrentUserIsNotDeveloper = "当前用户不是开发人员";
        public const string CurrentUserIsNotTester = "当前用户不是测试人员";
        public const string WeeklyIsNotExist = "周报不存在";
        public const string OverTitleMaxLength = "名称最大长度不能超过2000";
        public const string BugIsTestDone = "Bug已经测试完成不可拖拽至其他Sprint中";

    }
}
