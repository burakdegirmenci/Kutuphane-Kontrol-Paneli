﻿namespace BookStoreMVC.Application.DTOs.AdminDTOs;

public class AdminUpdateDTO
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
}