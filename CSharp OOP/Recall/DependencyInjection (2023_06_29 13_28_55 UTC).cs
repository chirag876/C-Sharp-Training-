﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IService
{
    void Serve();
}
public class Service1 : IService
{
    public void Serve()
    {
        Console.WriteLine("Service1 Called");
    }
}
public class Service2 : IService
{
    public void Serve()
    {
        Console.WriteLine("Service2 Called");
    }
}
public class Client
{
    private IService _service;
    public Client(IService service)
    {
        this._service = service;
    }
    public void ServeMethod()
    {
        this._service.Serve();
    }
}