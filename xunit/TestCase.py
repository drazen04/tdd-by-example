from TestResult import TestResult


class TestCase:
    def __init__(self, name):
        self.name = name
    def run(self):
        result = TestResult()
        try: 
            result.testStarted()
            self.setUp()
            method = getattr(self, self.name)
            method()
            self.tearDown()
        except:
            result.testFailed()
        finally:
            self.tearDown()
        return result
    def tearDown(self):
        pass