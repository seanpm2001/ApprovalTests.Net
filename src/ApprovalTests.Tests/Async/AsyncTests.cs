﻿using System.Threading.Tasks;
using ApprovalTests.Reporters;
using NUnit.Framework;

namespace ApprovalTests.Tests.Async;

[TestFixture]
[UseReporter(typeof(MachineSpecificReporter))]
public class AsyncTests
{
    [Test]
    public async Task TestAsync()
    {
        var text = await AsyncMethod();
        Approvals.Verify(text);
    }

    static async Task<string> AsyncMethod()
    {
        await Task.Delay(1);
        return "This came asynchronously";
    }
}