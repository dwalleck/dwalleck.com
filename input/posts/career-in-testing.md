Title: What You Might Learn From a Career in Software Testing
Lead: A road only traveled by the brave or foolish
Published: 4/2/2018
Tags:
  - Testing
---

This is a post I've wanted to write for some time now, but have never felt fully
comfortable writing. I say "might" in the title of this post because lessons
learned vary greatly based on your industry, the types of projects you work on,
and the tools or languages you use in testing. That said, I still wanted to
share my experiences to help better answer the question: "Why testing?"

# Some background

Let’s be clear: as a bright-eyed soon-to-be college grad, I had no intention of starting my career as a software tester. I had grand ambitions of building…something, but software testing wasn’t anywhere on my radar. So of course that meant, as many unsure college grads do, that I ended up with QA as my first role. And I was angry. “These people don’t respect my ability to code! They must think I’m awful! Or I must be awful…” was the line of thinking I had for my first year on the job. I kept these thoughts to myself until my first yearly review, at which time I laid out my well thought out argument about why I thought I was being misused and how I needed to be transitioned to a developer position immediately. I clearly remember the mixed look of confusion and frustration on my manager’s face as I wrapped up my monologue, at which I was now expecting to hear all the awful things that I was afraid my peers and leaders had been thinking all year. I can’t remember his exact words anymore, but his reply was essentially “You’re an idiot/You’re not getting it all. We’re keeping you in testing because you’re actually really good at it!”. Armed we this new knowledge, I thanked my boss and went home to ponder this new knowledge. “Good at software testing? What in the world do I do now? Am I never going to be a real software developer?” I could go on for hours describing the levels of self-doubt I had, but after talking with my leaders more and getting assurances I was going to still be a real software developer, I let go of the doubt and dived into my career. Still, it was hard because none of my peers had experienced being a long-term testers, so I had no idea of what to expect. That’s why now, for those who might be 12 years behind me, I’d like to give you an idea of what you might be able to expect.

# You’ll learn how to write great automated tests

You’ll learn how to write great automated tests. This may seem like the “duh” item of the list. It’s your primary role, right? And doesn’t every developer have to write automated tests anyway? First off, no, not every developer writes many tests. Most importantly, not all developers write good automated tests. The funny thing is, it turns out that writing good tests is hard. Really hard. Anyone can write a few dozen tests without it turning into a ball of spaghetti, but how about a hundred? How about a few hundred? Your “just my tests” just became its own application with its own set of concerns. Logging, configuration management, data access. All of those “developer concerns” just landed in your lap. You can try to do “just enough” to get by, but what about the next dozen projects you work on? Do you really want to write all that code again? Which brings me to…

# You’ll become a great library author

You’ll become a great library author. All that config management stuff? Package that up as a library to us again later. Wrapped some http clients with logging? New package. Wrote some helpful decorators? New package. And all of those libraries need the same love as any other library, which means tests (testing your test code? Inconceivable!), CI, docs, packaging, and examples. Sure, you can get away with just copying code between projects, but do you really want to?

# You’ll learn CI and infrastructure tools

You’ll learn CI and infrastructure tools. For the first 3-4 years of my career, I spent the first week of every new project spinning up a new VM, installing and configuring Visual Studio, Java, and a bunch of other build tools, and configuring CruiseControl.NET. And I always made the same mistakes. Waste of time. Tools like Jenkins and Docker and completely redefined how setting up a basic CI works. And guess what? It could be your job to manage it all. Automate it all away with Docker, Jenkins, Kubernetes, Ansible, or whatever tools you need. But it could be all on you. (Oh yeah, and use that all with the libraries you build too. See a pattern here?)

- configuration management

# You’ll get really good at parsing and outputting files

Wait, where did this one come from?

# You'll learn how to be a better communicator

More than just filing bug reports, you'll learn how to better communicate with
your team. While this is not always the case, sometimes members of the team will
cringe at the site of a tester on approach to their desk. A visit from us either
means "something is broken" or "I don't understand how this feature works".
Either way, it's a disruption to whatever that person was doing at the moment.
While you don't have to try to make those interactions more positive, it
certainly helps to not gleefully 

## You'll learn how to file great bug reports

This is hopefully the most obvious item on this list. Other than writing test
automation, it's the most obviously required skill. It's actually a great
skill for anyone involved in the project, from developers to project managers.
Writing clear bug reports not only make it easier for developers to understand
what the potential issue is, but they also help to identify where
misunderstandings may have occurred between the envisioning and implementation
of a feature.

I could (and probably will one day) write an entire blog post about the contents
of a "good" bug reports, but the basic requirements are:

- A title that concisely describes the issue
- A summary that explains both the encountered behavior and the expected behavior

Bonus points for:

- A script or test that reproduces the issue (I would put this under the "must
  haves" but not all things are easily testable)
- Links referencing the expected behavior
- Screenshots or logs of the issue occurring from client-side and (even better)
  server-side

# A higher level perspective of projects

One could argue that developers care about producing code, product managers care
about releasing features, but who on the team is acutely aware of all of these
concerns? As a testers, most likely you!

# Insight Into New Domains

To be clear, you may not always have this experience on a project. Many
applications are simply CRUD applications that don't represent a specific
domain. However, if you are fortunate enough to find yourself working on
projects that require knowledge of a specific domain to test effectively, 

This one is YMMV a bit since it depends on the purpose of the application.
Testing the reservation application for a theme park may give you some insight
into the general operations of a park, but testing a SaaS service that provides
virtual machines like AWS EC2 or Azure Virtual Machines will certainly require
a great deal of domain knowledge to test. This can create a more steep learning
when onboarding, but you'll leave the project far more knowledgable about a
domain than when you started.

