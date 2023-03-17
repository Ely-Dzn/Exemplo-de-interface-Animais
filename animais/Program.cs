// See https://aka.ms/new-console-template for more information

using animais;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Gato mau = new Gato();
        cachorro Cao = new cachorro();

        mau.EmiteSom();
        Cao.EmiteSom();
    }
}