﻿using System;

namespace DesignPatterns.Facade
{
    public sealed class Transaction
    {
        private bool _transaction = false;

        public void Start()
        {
            _transaction = true;
        }

        public void Do(Action action)
        {
            action();
        }

        public void End()
        {
            _transaction = false;
        }
    }
}