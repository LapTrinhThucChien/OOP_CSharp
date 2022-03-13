namespace EmployeeManagement
{
    internal interface ISendMail
    {
        void SendRegularMail(string mailFrom, string mailTo, string title, string content, string template);

        void SendRegularMail(string mailFrom, string mailTo, string mailCC, string title, string content, string template);
    }
}