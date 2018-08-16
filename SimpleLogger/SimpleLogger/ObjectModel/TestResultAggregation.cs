// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace SimpleLogger.ObjectModel
{
    using System;
    using System.Collections.Generic;
    using SimpleLogger.XML;

    /// <summary>
    /// Test result aggregation.
    /// </summary>
    internal class TestResultAggregation : TestResult, ITestResultAggregation
    {
        protected List<ITestResult> innerResults;

        public TestResultAggregation(
            Guid runId,
            Guid testId,
            Guid executionId,
            Guid parentExecutionId,
            string resultName,
            string computerName,
            TestOutcome outcome,
            TestType testType,
            TestListCategoryId testCategoryId) : base(runId, testId, executionId, parentExecutionId, resultName, computerName, outcome, testType, testCategoryId) { }

        /// <summary>
        /// Gets the inner results.
        /// </summary>
        public List<ITestResult> InnerResults
        {
            get
            {
                if (innerResults == null)
                {
                    innerResults = new List<ITestResult>();
                }
                return innerResults;
            }
        }

        public override void Save(System.Xml.XmlElement element, XmlTestStoreParameters parameters)
        {
            base.Save(element, parameters);

            XmlPersistence helper = new XmlPersistence();
            if (this.InnerResults.Count > 0)
                helper.SaveIEnumerable(this.InnerResults, element, "InnerResults", ".", null, parameters);
        }
    }
}