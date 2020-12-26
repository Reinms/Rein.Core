namespace Rein.Core.NetUtils
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public static class DelegateXtn
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        /// <param name="methodErrorPairs"></param>
        /// <returns>False if any errors occured</returns>
        public static Boolean SafeInvoke(this Action? action, out IEnumerable<(MethodInfo? method, Exception? error)> methodErrorPairs)
        {
            methodErrorPairs = Enumerable.Empty<(MethodInfo? method, Exception? error)>();
            Boolean res = true;
            if(action is null) return true;
            var il = action.GetInvocationList();
            if(il.Length == 1)
            {
                if(il[0] is not Action act)
                {
                    methodErrorPairs = methodErrorPairs.Append((il[0]?.Method, new NullReferenceException("Not an Action")));
                    return false;
                }
                try
                {
                    act();
                } catch(Exception e)
                {
                    methodErrorPairs = methodErrorPairs.Append((act.Method, e));
                    return false;
                }
            } else
            {
                foreach(var del in il)
                {
                    if(del is not Action act)
                    {
                        methodErrorPairs = methodErrorPairs.Append((del?.Method, new NullReferenceException("Not an Action")));
                        res = false;
                        continue;
                    }
                    if(!act.SafeInvoke(out var errors))
                    {
                        methodErrorPairs = methodErrorPairs.Concat(errors);
                        res = false;
                        continue;
                    }
                }
            }
            return res;
        }
    }
}
