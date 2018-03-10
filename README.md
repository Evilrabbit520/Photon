Photon Windows桌边版本
=======================

[![Build Status]][Appveyor]

[中文说明]

### 功能

1.系统代理设置
2.PAC 模式和全局模式
3.GFWList 和用户规则
4.支持 HTTP 代理
5.支持多服务器切换
6.支持 UDP 代理

#### Download

去 [Photon官网]下载最新版本.

#### Requirements

需要安装 [.NET Framework 4.6.2]. 

#### 基本使用

1.在任务栏找到 Shadowsocks 图标
2.在 服务器 菜单添加多个服务器
3.选择 启用系统代理 来启用系统代理。请禁用浏览器里的代理插件，或把它们设置为使用系统代理。
4.除了设为系统代理，你也可以直接自己配置浏览器代理。在 SwitchyOmega 中把代理设置为 SOCKS5 或 HTTP 的 127.0.0.1:1080。这个 1080 端口可以在服务器设置中设置。

#### 授权

SWL_0内部授权


[Appveyor]:       https://ci.appveyor.com/project/celeron533/shadowsocks-windows
[Build Status]:   https://ci.appveyor.com/api/projects/status/tfw57q6eecippsl5/branch/master?svg=true
[latest release]: https://github.com/shadowsocks/shadowsocks-csharp/releases
[GFWList]:        https://github.com/gfwlist/gfwlist
[Servers]:        https://github.com/shadowsocks/shadowsocks/wiki/Ports-and-Clients#linux--server-side
[中文说明]:       https://github.com/shadowsocks/shadowsocks-windows/wiki/Shadowsocks-Windows-%E4%BD%BF%E7%94%A8%E8%AF%B4%E6%98%8E
[.NET Framework 4.6.2]: https://www.microsoft.com/en-US/download/details.aspx?id=53344
[Visual Studio 2015]: https://www.visualstudio.com/downloads/
[.NET Framework 4.6.2 Developer Pack]: https://www.microsoft.com/download/details.aspx?id=53321
