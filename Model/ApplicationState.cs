﻿namespace BlazorApp1.Model
{
    public class ApplicationState
    {
        public int CurrentCounter { get; set; } = 1;

        public void Increment()
        {
            CurrentCounter++;
        }

    }
}
