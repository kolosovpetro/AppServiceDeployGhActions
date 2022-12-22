using System;

namespace WebApp.Models;

public class ErrorViewModel
{
    public string RequestId { get; set; }

    public bool ShowRequestId => !String.IsNullOrEmpty(RequestId);
}