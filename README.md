# pnunit-browserstack
[PNUnit](http://www.nunit.org/index.php?p=pnunit&r=2.5) Integration with BrowserStack.

![BrowserStack Logo](https://d98b8t1nnulk5.cloudfront.net/production/images/layout/logo-header.png?1469004780)

## Setup
* Download and install [NUnit 2.6.4](https://github.com/nunit/nunitv2/releases/2.6.4)
* Run PNUnit agent `start pnunit-agent.exe agent.conf`
* Clone the repo
* Open the solution `PNUnit-BrowserStack.sln` in Visual Studio
* Build the solution
* Update `*.config.xml` files inside the `config` directory with your BrowserStack Username and Access Key(https://www.browserstack.com/accounts/settings)

## Running your tests
- To run a single test, run `pnunit-launcher.exe config\single.config.xml`
- To run local tests, run `pnunit-launcher.exe config\local.config.xml`
- To run parallel tests, run `pnunit-launcher.exe config\parallel.config.xml`

 Understand how many parallel sessions you need by using our [Parallel Test Calculator](https://www.browserstack.com/automate/parallel-calculator?ref=github)

## Notes
* You can view your test results on the [BrowserStack automate dashboard](https://www.browserstack.com/automate)
* To test on a different set of browsers, check out our [platform configurator](https://www.browserstack.com/automate/c-sharp#setting-os-and-browser)
* You can export the environment variables for the Username and Access Key of your BrowserStack account

  ```
  export BROWSERSTACK_USERNAME=<browserstack-username> &&
  export BROWSERSTACK_ACCESS_KEY=<browserstack-access-key>
  ```

## Additional Resources
* [Documentation for writing automate test scripts in C#](https://www.browserstack.com/automate/c-sharp)
* [Customizing your tests on BrowserStack](https://www.browserstack.com/automate/capabilities)
* [Browsers & mobile devices for selenium testing on BrowserStack](https://www.browserstack.com/list-of-browsers-and-platforms?product=automate)
* [Using REST API to access information about your tests via the command-line interface](https://www.browserstack.com/automate/rest-api)
