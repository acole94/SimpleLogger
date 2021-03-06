// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace SimpleLogger.ObjectModel
{
    using System;

    /// <summary>
    /// Class for unit test result.
    /// </summary>
    internal class UnitTestResult: TestResultAggregation
    {
        public UnitTestResult(
            Guid runId,
            Guid testId,
            Guid executionId,
            Guid parentExecutionId,
            string resultName,
            string computerName,
            string ticketNumber,
            TestOutcome outcome,
            TestType testType,
            TestListCategoryId testCategoryId) : base(runId, testId, executionId, parentExecutionId, resultName, computerName, ticketNumber, outcome, testType, testCategoryId) { }
    }
}
