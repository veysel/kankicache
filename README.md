[![kankicache](https://raw.githubusercontent.com/veysel/kankicache/main/content/logo.png)](https://github.com/veysel/kankicache)

# kankicache
Kanki Cache

[![NuGet version](https://badge.fury.io/nu/kankicache.svg)](https://www.nuget.org/packages/kankicache/)
[![Build Status](https://travis-ci.com/veysel/kankicache.svg?branch=main)](https://travis-ci.com/github/veysel/kankicache)

<br>

## How to use ?

### Install kankicache

```
Install-Package kankicache

or

dotnet add package kankicache
```

<br>

### Import Project

```c#
using kankicache;
```

<br>

### Has Value

```c#
KankiCache.HasValue("keyname");
```

<br>

### Add Value (Default Expiration: 1 Hour)

```c#
KankiCache.AddValue("keyname", "value-test");
```

<br>

### Add Value With Expiration (Expiration Parameter Type: Minute)

```c#
KankiCache.AddValueWithExpiration("keyname", "value-test", 10); // 10 minute expiration
```

<br>

### Get Value

```c#
KankiCache.GetValue("keyname");
```

<br>

### Remove Value

```c#
KankiCache.RemoveValue("keyname");
```