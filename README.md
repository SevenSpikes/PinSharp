# PinSharp

[![AppVeyor](https://img.shields.io/appveyor/ci/Krusen/pinsharp.svg?style=flat-square)](https://ci.appveyor.com/project/Krusen/pinsharp)
[![NuGet](https://img.shields.io/nuget/v/PinSharp.svg?style=flat-square)](https://www.nuget.org/packages/PinSharp/1.0.0)
[![NuGet](https://img.shields.io/nuget/dt/PinSharp.svg?style=flat-square)](https://www.nuget.org/packages/PinSharp/1.0.0)

An async C# wrapper library for the Pinterest API.

- https://developers.pinterest.com/docs/getting-started/introduction/

## Notice
This project is still in the early phases and as such breaking changes might be introduced regularly. Use at your own risk.

## Examples

You need an access token to use the API. 

If you don't have one already you can generate one here: https://developers.pinterest.com/tools/access_token/

```C#
// Create a client with your access token
var client = new PinterestClient("AB_IBS7Q0fFQbXJ90JGtSDXNMV-tEBkfLftbK6JCpEWkGoA_MwAAAAA");

// Get board information
var board = await client.Boards.GetBoardAsync("machineshopcafe/best-of-mclaren-machine");

// Get pins on board
var pins = await client.Boards.GetPinsAsync("machineshopcafe/best-of-mclaren-machine");

// Get pins on board but only with fields 'creator' and 'board' as dynamic or your own type
var pins = await client.Boards.GetPinsAsync<dynamic>("rice_up/tableware", new[] { "creator", "board" });

// Get user info of the user associated with the access token
var user = await client.Me.GetUserAsync();

// Get pins of the user associated with the access token
var pins = await client.Me.GetPinsAsync();

// Get boards of the user associated with the access token
var boards = await client.Me.GetBoardsAsync();

// Search the associated user's pins or boards
var pins = await client.Me.SearchPinsAsync("mclaren");
var boards = await client.Me.SearchBoardsAsync("mclaren");

// Create new pin
var newPin = await client.Pins.CreatePinAsync("machineshopcafe/best-of-mclaren-machine", "http://i.imgur.com/abcdef.jpg", "Looks so cool!");

// Follow/unfollow board or user
await client.Me.FollowBoardAsync("machineshopcafe/best-of-mclaren-machine");
await client.Me.UnfollowBoardAsync("machineshopcafe/best-of-mclaren-machine");
await client.Me.FollowUserAsync("machineshopcafe");
await client.Me.UnfollowUserAsync("machineshopcafe");
```


## Future improvements

- Documentation
- Error handling
