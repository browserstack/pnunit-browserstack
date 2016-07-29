# pnunit-browserstack
[PNunit](http://www.nunit.org/index.php?p=pnunit&r=2.5) Integration with BrowserStack.

![BrowserStack Logo](https://d98b8t1nnulk5.cloudfront.net/production/images/layout/logo-header.png?1469004780)

## Setup
* Clone the repo
* Download and extract [NUnit 2.6.4](https://github.com/nunit/nunitv2/releases/2.6.4)
* Open the solution `PNUnit-BrowserStack.sln` in Visual Studio
* Build the solution
* Update `*.config.xml` files inside the `config` directory with your BrowserStack Username and Access Key(https://www.browserstack.com/accounts/settings)
* Run PNUnit agent `start pnunit-agent.exe agent.conf`

## Running your tests
- To run a single test, run `pnunit-launcher.exe config\single.config.xml`
- To run parallel tests, run `pnunit-launcher.exe config\parallel.config.xml`
- To run local tests, run `pnunit-launcher.exe config\local.config.xml`

## Notes
* You can view your test results on the [BrowserStack automate dashboard](https://www.browserstack.com/automate)
* To test on a different set of browsers, check out our [platform configurator](https://www.browserstack.com/automate/csharp#setting-os-and-browser)
* You can export the environment variables for the Username and Access Key of your BrowserStack account

  ```
  export BROWSERSTACK_USERNAME=<browserstack-username> &&
  export BROWSERSTACK_ACCESS_KEY=<browserstack-access-key>
  ```

## Additional Resources
* [Documentation for writing automate test scripts in C#](https://www.browserstack.com/automate/csharp)
* [Customizing your tests on BrowserStack](https://www.browserstack.com/automate/capabilities)
* [Browsers & mobile devices for selenium testing on BrowserStack](https://www.browserstack.com/list-of-browsers-and-platforms?product=automate)
* [Using REST API to access information about your tests via the command-line interface](https://www.browserstack.com/automate/rest-api)
