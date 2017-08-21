No one likes failing tests. Failing tests stop builds and take human time to understand what went wrong. People especially hate tests that seem to fail are the ones that **always** seem to fail. Even worse are the tests that fail at odd times for no apparent reason. These tests often end up labeled as "the flakey tests": the black sheep of the test suite family. The one tag no test wants to receive. Almost a death sentence with regards In the best case, they get skipped or ignored as irrelevant results. In the worst case, they get deleted outright. 

When you're focused on results and delivery, it's easy to want to write these tests off as an annoyance or impedance to velocity. It can be easy to say that a test was poorly designed (which happens). However, some of the time that test is trying to tell you something even if it's not apparent at first.

**A significant number of critical defects I've discovered (working on OpenStack) came from "flaky" test failures. Flaky test failures have helped me identify memory leaks, race conditions, and insufficient resources (not enough memory allocated for MySQL**

It's also been a lesson in poor/unreliable test patterns, which is a whole other topic in itself. 

The cause of flaky or unstable tests can vary wildly. Sometimes you might be testing a workflow that needed *just* a second or more to complete. Sometimes the test is poorly designed, relying on data that may or may not exist at runtime. The most frustrating case is when the test failure appears to be legitimate, but is not immediately reproducible.

* Check the test code for any bad practices (arbitrary sleeps, poorly designed functions, race conditions)
* Sleeps that wait for some action to complete. For better reliability, include retries with some reasonable timeout limit
* Look for consistency (look back at the last 100/N runs
* Run the test in isolation from the rest of the test suite
* Gather application logs during the period of the test runs to look for hints of where things may be going wrong

Ideally this is a process that should happen automatically out-of-band, but the state of CI is better at identifying flakey tests rather than understanding them (to be fair, it's probably not the responsibility of the CI system to do so. However, having a process that worked in harmony with the CI system to identify problems would be more time effective).