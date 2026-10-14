# C# 英文打字练习系统

一个 Windows Forms 课程项目，把英文输入练习、逐字反馈、计时成绩和落字小游戏放进同一个桌面程序。通过窗体事件、计时器和本地文件，练习交互状态管理与数据保存。

作者 / 维护者：迟凡杰。当前为公开整理的课程源码版；未核验再分发许可的装饰图片已移除，窗体和按钮文字保留，公开版外观较原课程工程简化。

## 主要功能

| 功能 | 代码入口 | 实现重点 |
| --- | --- | --- |
| 随机字符练习 | `Form5.cs`、`Form7.cs` | 随机序列、逐字比较、颜色反馈与计时 |
| 短文练习 | `Form8.cs` | 加载本地文本，比较输入结果 |
| 放大键盘提示 | `Form15.cs` | 按键事件、键位定位与正确/错误反馈 |
| 落字射击小游戏 | `Form4.cs` | Timer 驱动字母生成与下落，维护得分和生命值 |
| 成绩查看 | `Form10.cs`、`Form14.cs` | 读取本地练习记录 |
| 菜单与教学页 | `Form3.cs`、`Form6.cs`、`Form9.cs` | 模式选择、窗体切换及可选图片浏览 |
| 本地登录实验 | `Form1.cs`、`Form2.cs` | 文本文件读写演示，见下方账号限制 |

## 构建

原工程为 **Windows Forms / .NET Framework 4.0 Client Profile / x86**，不是 .NET Core 或跨平台应用。

在 Windows 上使用支持旧版 .NET Framework 工程的 Visual Studio，并安装对应目标框架组件。打开 `san ji xiang mu.sln`，选择 `Debug | x86` 后生成。若当前 Visual Studio 不支持 4.0，可在工作副本中显式重定向到本机已安装的 .NET Framework（如 4.8），再验证兼容性。

已配置 MSBuild 与对应 targeting pack 的 Developer PowerShell 可运行：

```powershell
msbuild 'san ji xiang mu.sln' /p:Configuration=Debug /p:Platform=x86
```

预期输出：`san ji xiang mu/bin/Debug/san ji xiang mu.exe`。

## 准备演示数据

仓库不携带真实账号、密码或个人成绩。首次启动前，在根目录运行：

```powershell
./prepare-demo.ps1
& './san ji xiang mu/bin/Debug/san ji xiang mu.exe'
```

脚本创建空账号文件和原创合成英文练习文本，**不会覆盖已有文件**。Release 构建可指定：

```powershell
./prepare-demo.ps1 -OutputDirectory './san ji xiang mu/bin/Release'
```

注册一个仅用于本地演示的虚构账号，再登录进入菜单。不要使用真实服务的用户名/密码。示例短文为：

```text
Practice slowly, keep your eyes on the screen, and let accuracy come before speed.
```

输入相同字符观察匹配反馈，故意改一个字符观察错误高亮；结束后从菜单查看演示账号的记录。计时和统计沿用课程逻辑，没有新增准确率或性能基准。

## 文件与可选资源

```text
san ji xiang mu.sln
san ji xiang mu/
  Form*.cs / *.Designer.cs / *.resx  交互逻辑、窗体布局与文字资源
  Program.cs                       程序入口
  Class1.cs                        当前用户与可选资源辅助
prepare-demo.ps1                   创建空账号文件及合成文本
THIRD_PARTY.md                     原素材处理边界
```

原机器桌面的绝对路径已替换为应用输出目录下的相对位置。图片/音效均为可选，可自行放入有权使用的素材：

- `game/fj.png`、`game/bj.png`：小游戏图片。
- `yinyue/爆炸.WAV`：可选音效。
- `tupian/` 下对应教学分类目录：键盘教学图片。

也可用 `TYPING_TUTOR_ASSETS` 环境变量指定包含相同结构的资源根目录。没有素材时使用简化空白图片区域，放大键盘以红/绿色块反馈，不自动下载外部资源。

## 账号与课程实现边界

- 登录/注册保留原课程的**明文文本存储**，仅用于本地文件 I/O 演示，不是安全认证实现，不可部署为真实账号系统。
- 准备脚本不生成固定密码；请自行创建虚构账号。账号和成绩保存在构建输出目录，不纳入 Git。
- 计分、窗体生命周期、教学翻页和输入长度边界仍沿用原实现，尚无覆盖全部交互的自动化测试。
- 2026-10-14 使用 Windows 自带 MSBuild 完成原目标 `Debug | x86` 构建；保留一条旧的 `CS0108` 警告（键盘按钮 `Enter` 与继承成员同名）。
- 以 x86 / STA 进程无窗口实例化并释放了 15 个窗体；准备脚本通过“保留已有内容、创建空账号文件”检查。这些检查不等同于完整交互验收。

## 作者、素材与许可证

项目展示本人课程学习与桌面应用实践。公开整理移除了未核验授权的嵌入背景/图标及个人联系邮箱，保留作者署名，并提供合成文本。

尚未完成全部历史代码来源授权核对，**当前未授予统一开源许可证**。公开可阅读不等于对所有文件授予复制、修改或再分发许可。第三方名称及组件权利仍归相应权利人，见 [THIRD_PARTY.md](THIRD_PARTY.md)。
