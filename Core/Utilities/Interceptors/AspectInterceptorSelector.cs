using Castle.DynamicProxy;
using System.Reflection;
using Core.Aspects.Logging;
using Core.Aspects.Performance;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;

namespace Core.Utilities.Interceptors
{
    public partial class Class1
    {
        public class AspectInterceptorSelector : IInterceptorSelector
        {
            public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
            {
                var classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute>
                    (true).ToList();
                var methodAttributes = type.GetMethod(method.Name)
                    .GetCustomAttributes<MethodInterceptionBaseAttribute>(true);
                classAttributes.AddRange(methodAttributes);
                classAttributes.Add(new PerformanceAspect(5)); //performance aspectimi tüm projede çalıştırmak için istersem metodların üstünede yazabilirdim
                classAttributes.Add(new LogAspect(typeof(FileLogger)));

                return classAttributes.OrderBy(x => x.Priority).ToArray();
            }
        }
    }
}
