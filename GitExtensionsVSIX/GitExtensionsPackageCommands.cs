namespace GitExtensionsVSIX
{
    using System;
    
    /// <summary>
    /// Helper class that exposes all GUIDs used across VS Package.
    /// </summary>
    internal sealed partial class PackageGuids
    {
        public const string guidGitExtensionsPackageString = "14f45fb8-a093-48af-a2a2-a7bb404cb357";
        public const string guidGitExtensionsPackageCmdSetString = "8bd71b0f-f446-442d-a92a-bbefd8e60202";
        public const string guidImagesString = "8bcce2c8-daec-4814-878e-e9c346d42f24";
        public static Guid guidGitExtensionsPackage = new Guid(guidGitExtensionsPackageString);
        public static Guid guidGitExtensionsPackageCmdSet = new Guid(guidGitExtensionsPackageCmdSetString);
        public static Guid guidImages = new Guid(guidImagesString);
    }
    /// <summary>
    /// Helper class that encapsulates all CommandIDs uses across VS Package.
    /// </summary>
    internal sealed partial class PackageIds
    {
        public const int gitExtMenu = 0x1000;
        public const int gitExtMenuGlobalGroup = 0x1010;
        public const int gitExtMenuChangesGroup = 0x1011;
        public const int gitExtMenuPatchGroup = 0x1012;
        public const int gitExtMenuFindGroup = 0x1013;
        public const int gitExtMenuBranchGroup = 0x1014;
        public const int gitExtMenuOtherGroup = 0x1015;
        public const int gitExtContextualMenu = 0x1020;
        public const int gitExtToolbar = 0x1030;
        public const int gitExtToolbarGroup = 0x101031;
        public const int gitExtDiffCommand = 0x1100;
        public const int gitExtHistoryCommand = 0x1101;
        public const int gitExtResetFileCommand = 0x1102;
        public const int gitExtBrowseCommand = 0x1103;
        public const int gitExtCloneCommand = 0x1104;
        public const int gitExtNewCommand = 0x1105;
        public const int gitExtCommitCommand = 0x1106;
        public const int gitExtPullCommand = 0x1107;
        public const int gitExtPushCommand = 0x1108;
        public const int gitExtStashCommand = 0x1109;
        public const int gitExtRemotesCommand = 0x110A;
        public const int gitExtGitIgnoreCommand = 0x110B;
        public const int gitExtApplyPatchCommand = 0x110C;
        public const int gitExtFormatPatchCommand = 0x110D;
        public const int gitExtViewChangesCommand = 0x110E;
        public const int gitExtFindFileCommand = 0x110F;
        public const int gitExtCheckoutCommand = 0x1110;
        public const int gitExtCreateBranchCommand = 0x1111;
        public const int gitExtMergeCommand = 0x1112;
        public const int gitExtRebaseCommand = 0x1113;
        public const int gitExtSolveConflictsCommand = 0x1114;
        public const int gitExtCherryPickCommand = 0x1115;
        public const int gitExtBashCommand = 0x1116;
        public const int gitExtSettingsCommand = 0x1117;
        public const int gitExtAboutCommand = 0x1118;
        public const int edit = 0x0001;
        public const int configure = 0x0002;
        public const int stash = 0x0003;
        public const int reset = 0x0004;
        public const int editAll = 0x0005;
        public const int history = 0x0006;
        public const int commit = 0x0007;
        public const int push = 0x0008;
        public const int pull = 0x0009;
        public const int createBranch = 0x000A;
        public const int unused = 0x000B;
        public const int browse = 0x000C;
        public const int @new = 0x000D;
        public const int clone = 0x000E;
        public const int cherry = 0x000F;
        public const int checkout = 0x0010;
        public const int remotes = 0x0011;
        public const int merge = 0x0012;
        public const int rebase = 0x0013;
        public const int about = 0x0014;
        public const int bash = 0x0015;
        public const int gitignore = 0x0016;
        public const int find = 0x0017;
        public const int diff = 0x0018;
    }
}
