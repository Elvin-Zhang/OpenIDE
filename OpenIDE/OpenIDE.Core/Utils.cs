using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Dynamic;
using System.IO;
using System.Linq;

namespace OpenIDE.Core
{
    public static class Utils
    {
        public static Guid GetTemplateID(string src)
        {
            return Workspace.PluginManager.Plugins.SelectMany(_ => _.ItemTemplates).
                Where(_ => _.Extension == Path.GetExtension(src)).Select(_ => _.ID).FirstOrDefault();
        }

        private static readonly CSharpArgumentInfo argInfo = CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null);

        public static object DynamicInvoke(object target, params object[] args)
        {
            var del = target as Delegate;
            if (del != null)
                return del.DynamicInvoke(args);
            var dynamicObject = target as DynamicObject;
            if (dynamicObject != null)
            {
                object result;
                var binder = Binder.Invoke(CSharpBinderFlags.None, null, Enumerable.Repeat(argInfo, args.Length));
                if (dynamicObject.TryInvoke((InvokeBinder)binder, args, out result))
                    return result;
            }
            throw new InvalidOperationException("Invocation failed");
        }
    }
}