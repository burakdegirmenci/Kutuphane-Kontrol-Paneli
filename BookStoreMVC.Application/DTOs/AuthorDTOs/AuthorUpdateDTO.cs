﻿namespace BookStoreMVC.Application.DTOs.AuthorDTOs;

public class AuthorUpdateDTO
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }
}
