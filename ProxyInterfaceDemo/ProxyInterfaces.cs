using ProxyInterfaceGenerator;

namespace ProxyInterfaceDemo;

[Proxy(typeof(Displayable), true, ProxyClassAccessibility.Internal)]
public partial interface IDisplayable
{
}

[Proxy(typeof(Destroyable), true, ProxyClassAccessibility.Internal)]
public partial interface IDestroyable
{
}

[Proxy(typeof(Group), ProxyClassAccessibility.Internal)]
public partial interface IGroup : IDisplayable
{
}

[Proxy(typeof(Depth.Group), ProxyClassAccessibility.Internal)]
public partial interface IGroupDepth : IDisplayable
{
}