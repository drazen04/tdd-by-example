class TestResult:
    def __init__(self):
        self.runCount = 0
        self.failedCount = 0
    def testStarted(self):
        self.runCount += 1
    def testFailed(self):
        self.failedCount += 1
    def summary(self):
        return "%d run, %d failed" % self.runCount % self.failedCount