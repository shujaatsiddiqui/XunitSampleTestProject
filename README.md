# XunitSampleTestProject
This project contains Fluent assertion as well.

#References
https://fluentassertions.com/

https://www.youtube.com/watch?v=dsD0CMgPjUk&list=PLmvP3GN5ktSHvAkqDquCzuBoj7zC1kMXh&index=6

https://www.udemy.com/course/unit-testing-net-core-2x-applications-with-xunit-net/


#Topic: Class Fixtures and IClass Fixtures

https://xunit.net/docs/shared-context

When to use: when you want to create a single test context and share it among all the tests in the class, and have it cleaned up after all the tests in the class have finished.

Sometimes test context creation and cleanup can be very expensive. If you were to run the creation and cleanup code during every test, it might make the tests slower than you want. You can use the class fixture feature of xUnit.net to share a single object instance among all tests in a test class.

We already know that xUnit.net creates a new instance of the test class for every test. When using a class fixture, xUnit.net will ensure that the fixture instance will be created before any of the tests have run, and once all the tests have finished, it will clean up the fixture object by calling Dispose, if present.

To use class fixtures, you need to take the following steps:

Create the fixture class, and put the startup code in the fixture class constructor.
If the fixture class needs to perform cleanup, implement IDisposable on the fixture class, and put the cleanup code in the Dispose() method.
Add IClassFixture<> to the test class.
If the test class needs access to the fixture instance, add it as a constructor argument, and it will be provided automatically.

#Topic: Collection Defination

https://xunit.net/docs/shared-context

When to use: when you want to create a single test context and share it among tests in several test classes, and have it cleaned up after all the tests in the test classes have finished.

Sometimes you will want to share a fixture object among multiple test classes. The database example used for class fixtures is a great example: you may want to initialize a database with a set of test data, and then leave that test data in place for use by multiple test classes. You can use the collection fixture feature of xUnit.net to share a single object instance among tests in several test classes.

To use collection fixtures, you need to take the following steps:

Create the fixture class, and put the startup code in the fixture class constructor.
If the fixture class needs to perform cleanup, implement IDisposable on the fixture class, and put the cleanup code in the Dispose() method.
Create the collection definition class, decorating it with the [CollectionDefinition] attribute, giving it a unique name that will identify the test collection.
Add ICollectionFixture<> to the collection definition class.
Add the [Collection] attribute to all the test classes that will be part of the collection, using the unique name you provided to the test collection definition class's [CollectionDefinition] attribute.
If the test classes need access to the fixture instance, add it as a constructor argument, and it will be provided automatically.

#CoverLet Coverage

https://www.code4it.dev/blog/code-coverage-vs-2019-coverlet


