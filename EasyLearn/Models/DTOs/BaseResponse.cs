﻿namespace EasyLearn.Models.DTOs;

public class BaseResponse<T>
{
    public string Message { get; set; }
    public bool Success { get; set; }
    public T Data { get; set; }
}