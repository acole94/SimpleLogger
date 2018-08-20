﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SimpleLogger.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class TrxResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TrxResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SimpleLogger.Resources.TrxResource", typeof(TrxResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter cannot be less than 0..
        /// </summary>
        public static string Common_CannotBeLessThanZero {
            get {
                return ResourceManager.GetString("Common_CannotBeLessThanZero", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter cannot be null or empty..
        /// </summary>
        public static string Common_CannotBeNullOrEmpty {
            get {
                return ResourceManager.GetString("Common_CannotBeNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot get free name for {0}(1),(2),... in directory {1}. Please clean up this directory..
        /// </summary>
        public static string Common_CannotGetNextIterationName {
            get {
                return ResourceManager.GetString("Common_CannotGetNextIterationName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to deployment item &apos;{0}&apos;.
        /// </summary>
        public static string Common_DeploymentItem {
            get {
                return ResourceManager.GetString("Common_DeploymentItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to deployment item &apos;{0}&apos; (output directory &apos;{1}&apos;).
        /// </summary>
        public static string Common_DeploymentItemWithOutputDirectory {
            get {
                return ResourceManager.GetString("Common_DeploymentItemWithOutputDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Test Settings are not specified..
        /// </summary>
        public static string Common_MissingRunConfigInRun {
            get {
                return ResourceManager.GetString("Common_MissingRunConfigInRun", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The active Test Settings do not define the Run Deployment Directory..
        /// </summary>
        public static string Common_MissingRunDeploymentRootInRunConfig {
            get {
                return ResourceManager.GetString("Common_MissingRunDeploymentRootInRunConfig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The result is not associated with a test run. Use a result that was obtained from an in-progress or completed test run..
        /// </summary>
        public static string Common_MissingRunInResult {
            get {
                return ResourceManager.GetString("Common_MissingRunInResult", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified file/directory name &apos;{0}&apos; is not valid..
        /// </summary>
        public static string Common_NothingLeftAfterReplaciingBadCharsInName {
            get {
                return ResourceManager.GetString("Common_NothingLeftAfterReplaciingBadCharsInName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (null).
        /// </summary>
        public static string Common_NullInMessages {
            get {
                return ResourceManager.GetString("Common_NullInMessages", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}@{1} {2}.
        /// </summary>
        public static string Common_TestRunName {
            get {
                return ResourceManager.GetString("Common_TestRunName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to attach files from: {0}
        ///Error Details: {1}:{2}.
        /// </summary>
        public static string FailureToAttach {
            get {
                return ResourceManager.GetString("FailureToAttach", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Test &apos;{0}&apos; was skipped in the test run..
        /// </summary>
        public static string MessageForSkippedTests {
            get {
                return ResourceManager.GetString("MessageForSkippedTests", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Aborted.
        /// </summary>
        public static string TestOutcomeAborted {
            get {
                return ResourceManager.GetString("TestOutcomeAborted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Completed.
        /// </summary>
        public static string TestOutcomeCompleted {
            get {
                return ResourceManager.GetString("TestOutcomeCompleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Disconnected.
        /// </summary>
        public static string TestOutcomeDisconnected {
            get {
                return ResourceManager.GetString("TestOutcomeDisconnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error.
        /// </summary>
        public static string TestOutcomeError {
            get {
                return ResourceManager.GetString("TestOutcomeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed.
        /// </summary>
        public static string TestOutcomeFailed {
            get {
                return ResourceManager.GetString("TestOutcomeFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Inconclusive.
        /// </summary>
        public static string TestOutcomeInconclusive {
            get {
                return ResourceManager.GetString("TestOutcomeInconclusive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In Progress.
        /// </summary>
        public static string TestOutcomeInProgress {
            get {
                return ResourceManager.GetString("TestOutcomeInProgress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not Executed.
        /// </summary>
        public static string TestOutcomeNotExecuted {
            get {
                return ResourceManager.GetString("TestOutcomeNotExecuted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not Runnable.
        /// </summary>
        public static string TestOutcomeNotRunnable {
            get {
                return ResourceManager.GetString("TestOutcomeNotRunnable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Passed.
        /// </summary>
        public static string TestOutcomePassed {
            get {
                return ResourceManager.GetString("TestOutcomePassed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Passed (run aborted).
        /// </summary>
        public static string TestOutcomePassedButRunAborted {
            get {
                return ResourceManager.GetString("TestOutcomePassedButRunAborted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pending.
        /// </summary>
        public static string TestOutcomePending {
            get {
                return ResourceManager.GetString("TestOutcomePending", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Timeout.
        /// </summary>
        public static string TestOutcomeTimeout {
            get {
                return ResourceManager.GetString("TestOutcomeTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Warning.
        /// </summary>
        public static string TestOutcomeWarning {
            get {
                return ResourceManager.GetString("TestOutcomeWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Results File: {0}.
        /// </summary>
        public static string TrxLoggerResultsFile {
            get {
                return ResourceManager.GetString("TrxLoggerResultsFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WARNING: Overwriting results file: {0}.
        /// </summary>
        public static string TrxLoggerResultsFileOverwriteWarning {
            get {
                return ResourceManager.GetString("TrxLoggerResultsFileOverwriteWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to All Loaded Results.
        /// </summary>
        public static string TS_AllResults {
            get {
                return ResourceManager.GetString("TS_AllResults", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Results Not in a List.
        /// </summary>
        public static string TS_UncategorizedResults {
            get {
                return ResourceManager.GetString("TS_UncategorizedResults", resourceCulture);
            }
        }
    }
}
