﻿using System;
using System.Collections.Generic;
using Bridge.CLR;

namespace System.Threading.Tasks 
{
    [Ignore]
    [Name("Bridge.Task")]    
	public class Task : IDisposable 
    {
		public Task(Action action) 
        {
		}

		public Task(Action<object> action, object state) 
        {
		}

        public readonly Exception Exception;

        public readonly bool IsCanceled;
        public readonly bool IsCompleted;
        public readonly bool IsFaulted;
        public readonly TaskStatus Status;

		public virtual Task ContinueWith(Action<Task> continuationAction) 
        {
			return null;
		}

		public virtual Task<TResult> ContinueWith<TResult>(Func<Task, TResult> continuationFunction) 
        {
			return null;
		}

		public virtual void Start() 
        {
		}

		public virtual TaskAwaiter GetAwaiter() 
        {
			return null;
		}

		public virtual void Dispose() 
        {
		}

		public static Task Delay(int millisecondDelay) 
        {
			return null;
		}

		public static Task<TResult> FromResult<TResult>(TResult result) 
        {
			return null;
		}

		public static Task Run(Action action) 
        {
			return null;
		}

		public static Task<TResult> Run<TResult>(Func<TResult> function) 
        {
			return null;
		}

		public static Task WhenAll(params Task[] tasks) 
        {
			return null;
		}

		public static Task WhenAll(IEnumerable<Task> tasks) 
        {
			return null;
		}

		public static Task<TResult[]> WhenAll<TResult>(params Task<TResult>[] tasks) 
        {
			return null;
		}

		public static Task<TResult[]> WhenAll<TResult>(IEnumerable<Task<TResult>> tasks) 
        {
			return null;
		}

		public static Task<Task> WhenAny(params Task[] tasks) 
        {
			return null;
		}

		public static Task<Task> WhenAny(IEnumerable<Task> tasks) 
        {
			return null;
		}

		public static Task<Task<TResult>> WhenAny<TResult>(params Task<TResult>[] tasks) 
        {
			return null;
		}

		public static Task<Task<TResult>> WhenAny<TResult>(IEnumerable<Task<TResult>> tasks) 
        {
			return null;
		}

		public static Task FromCallback(object target, string method, params object[] otherArguments) 
        {
			return null;
		}

        public static Task FromCallbackResult(object target, string method, Delegate resultHandler, params object[] otherArguments)
        {
            return null;
        }

		public static Task<TResult> FromCallback<TResult>(object target, string method, params object[] otherArguments) 
        {
			return null;
		}

        public static Task<TResult> FromCallbackResult<TResult>(object target, string method, Delegate resultHandler, params object[] otherArguments)
        {
            return null;
        }

		public static Task<object[]> FromPromise(IPromise promise) 
        {
			return null;
		}

		public static Task<TResult> FromPromise<TResult>(IPromise promise, Delegate resultHandler) 
        {
			return null;
		}
	}

    [Ignore]
    [Name("Bridge.Task")]
	public class Task<TResult> : Task {
		
        public Task(Func<TResult> function) : base(() => {}) 
        {
		}

		public Task(Func<object, TResult> function, object state) : base(() => {}) 
        {
		}

		public virtual TResult Result 
        { 
            get 
            { 
                return default(TResult); 
            } 
        }

		public virtual Task ContinueWith(Action<Task<TResult>> continuationAction) 
        {
			return null;
		}

		public virtual new TaskAwaiter<TResult> GetAwaiter() 
        {
			return null;
		}

		public virtual Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction) 
        {
			return null;
		}
	}
}
