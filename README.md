# CalendarCompressor

Takes an existing Google Calendar and shrinks down meetings to fit in the shortest window.

Currently it retrieves all of next weeks events in your currently visibile calendars on Google Calendar.

## Prerequisites 

* [.Net Core 2.2 SDK](https://dotnet.microsoft.com/download)

## Set API Credentials

Follow the below instructions to set up your credentials for the Google Calendar API:

1. Go to https://developers.google.com/calendar/quickstart/dotnet
2. Click "Enable the Google Calendar API"
3. Follow the instructions until it is enabled
4. Download the `credentials.json` file
5. Copy the `credentials.json` file into the root of the `CalendarCompressor` project
6. Ensure the file reference in the csproj is set to "Copy always"

The `credentials.json` file is already marked as ignore in the `.gitignore` file, so won't be committed to the repo.

## Reference

* [Google Calendar API Quickstart](https://developers.google.com/calendar/quickstart/dotnet)