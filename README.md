# AntiCheatReportNotifier

## About
A simple mod that uses PokrukNotifyLib (a hard dependency) to notify you when your client reports another player. Additionally, the mod prevents reports from being sent if you are the only player in the lobby. 

Disabling all anti-cheat reports can make the anti-cheat system suspicious of you since you'd be the only one not reporting when others do. Therefore, completely disabling these reports is generally unwise. The safest approach is to avoid reporting yourself only if you are the sole player in the room.

Anti-cheat reports do not directly cause bans. They simply indicate that a report has been sent. Only the Gorilla Tag developers understand how these reports are processed. As mentioned, this mod shows only the reports made by your client, so you won’t see reports sent by other players. However, in most cases, if your client reports someone, other clients may report them as well.

## Use Cases
* Verify if your mod is being detected by the anti-cheat system.
* Identify cheating players in the lobby. For example, if a player is autotagging everyone, anti-cheat reports will reveal the cheater, allowing you to report them on the leaderboard and inform others to do the same.
* Understand which actions trigger anti-cheat responses.

## Dependencies
### Required
* [PokrukNotifyLib](https://github.com/Pokruk/PokrukNotifyLib)

### Optional
* PokrukMenu (private) - allows you to enable/disable the mod at runtime
