using StrongInject;

namespace MVE
{
    [Register(type: typeof(App), registerAs: typeof(IApp))]
    internal partial class Container : IContainer<IApp>
    {
    }
}
