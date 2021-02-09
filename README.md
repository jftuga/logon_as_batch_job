# logon_as_batch_job
Gives the 'logon as a batch job' privilege to a domain user

## Synopsis
The `logon as a batch job` privilege is required when creating a task from within `Task Scheduler`.  Setting this is normally accomplished with the `Local Security Policy` *(secpol.msc)* control.  However, this program is not included in `Windows Server Core`, thus making it difficult to configure.  This program solves this problem as it is a command-line tool.  In order for successful operation, it must be used in the `Run As Administrator` context.

___

## Usage

```
logon_as_batch_job.exe DomainName\UserName
```

## Example

```shell
C:>logon_as_batch_job.exe myDomain\myUserName
LookupAccountName result = True
IsValidSid: True
LookupAccountName domainName: MYDOMAIN
LsaAddAccountRights return value: 66307801059688448
```

## License
* [MIT License](LICENSE)

## Acknowledgments
* [Set Logon as batch job rights to User by Powershell, C# and CMD](https://morgantechspace.com/2014/03/set-logon-as-batch-job-rights-to-user-by-powershell-csharp-cmd.html)
* [How do I force my .NET application to run as administrator?](https://stackoverflow.com/questions/2818179/how-do-i-force-my-net-application-to-run-as-administrator)
