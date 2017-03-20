﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.Extensions.Advanced.Demo1
{
    public sealed class Instrumentation
    {
        public Guid Id { get; private set; }

        private DateTime startedAt;

        public string ProcessName { get; set; }

        public Instrumentation()
        {
            Id = Guid.NewGuid();
        }

        public void Start()
        {
            startedAt = DateTime.Now;
        }

        public int GetElapsedTime()
        {
            return (int)Math.Round(new TimeSpan(DateTime.Now.Ticks - startedAt.Ticks).TotalSeconds, 0);
        }
    }
}
