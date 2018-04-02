Title: My Take On The Components of a Test Project
Published: 3/20/2018
Tags: Testing
---


These may or may not be individual packages, but they come together as a
cohesive unit to solve a specific problem. The components I've identified from
my experience are:

- A test runner
- A test model
- A style of assertions
- An application driver
- Management of test data
- Management of test artifacts

# Test Runners

Test runners are what most developers tend to think of when discussing testing.
Any developer that has developed unit or integration tests has interacted with
a test runner to execute their tests, whether it be jUnit, pytest, nUnit, or
any of the other numerous test runners. When deciding on a test runner, there's
two important characteristics to take into the account.

The first is the "style" or "type" of tests the runner supports. In general,
there are two styles of tests: unit test and gherkin-style BDD. By unit
test-style tests, I mean tests that follow the general setup/test/teardown
model. BDD-style tests generally follow the Gherkin syntax and have step
definitions that implement actions to be take by tests. The decision of a runner
is heavily tied to the choice of the test model, but can have a great deal of
impact on its own. Test runners impact the following:

- Test selection (tagging/filtering of tests to execute)
- Parallelization of test execution
- Test generation from sets of data
- Generation of test output
  - Immediate to console/window
  - Generation of output logs
  - Generation of results of test run