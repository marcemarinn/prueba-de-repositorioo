﻿namespace Core.Entities;

public class User
{
    public int Id { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string PassWordHash { get; set; } = string.Empty;
}
