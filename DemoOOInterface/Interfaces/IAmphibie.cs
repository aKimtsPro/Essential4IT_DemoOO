﻿namespace DemoOOInterface.Interfaces;

public interface IAmphibie: INaviguer, IRouler
{
    public bool ModeMaritime { get; set; }
    public void ChangerMode();
}