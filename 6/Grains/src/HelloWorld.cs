﻿using System.Threading.Tasks;
using Interfaces;
using Orleans;
using Library;

namespace Grains
{
    public class HelloWorld : Orleans.Grain, IHelloWorld
    {
        public async Task<string> SayHello(string name, GrainCancellationToken grainCancellationToken)
        {
            string result = null;

            if (!grainCancellationToken.CancellationToken.IsCancellationRequested)
            {
                return await Task.FromResult(Say.hello(name));
            }

            return result;
        }
    }
}