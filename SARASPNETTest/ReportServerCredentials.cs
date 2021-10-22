using System;
using Microsoft.Reporting.WebForms;
using System.Security.Principal;
using System.Net;
using System.Configuration;

public class ReportServerCredentials : IReportServerCredentials
{
    public ReportServerCredentials()
    {
    }

    public WindowsIdentity ImpersonationUser
    {
        get
        {
            return null;
        }
    }

    public ICredentials NetworkCredentials
    {
        get
        {
            return null;
        }
    }

    public bool GetFormsCredentials(out Cookie authCookie, out string user, out string password, out string authority)
    {
        authCookie = null;
        user = ConfigurationManager.AppSettings["SARUserId"];
        password = ConfigurationManager.AppSettings["SARPassword"];
        authority = String.Empty;
        return true;
    }
}
