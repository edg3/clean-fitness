# clean-fitness
My personal fitness, exercise, and diet app

# License: GNU General Public License v3.0
Permissions of this strong copyleft license are conditioned on making available complete source code of licensed works and modifications, which include larger works using a licensed work, under the same license. Copyright and license notices must be preserved. Contributors provide an express grant of patent rights.

# What is Clean Fitness?
I felt like finally making the revamped version of my own personal fitness and exercise application. This is generally what I feel like using, to be useful, and to get myself back on track with my proper fitness schedules and plans.

# About and Ideas - Android Fitness App
Personal Exercise Tracking which has notifications as reminders
- Easily understandable exercise plan built in [see (1) below]
- Method for categorising with and without weights
- Tracking and graphs
- Personal body tracking
- Method to turn on 'Warm Up' before exercise - gives 5 minutes to Walk, Run, Cycle, Row, etc before the exercise - you can choose what and track it
- Muscle Grouping most likely helps with usability [TODO: in descriptions]

Personal Calories Tracking with which is meant to build the habit of not constantly eating 'too much'; more an assistant than a hardcore food management system
- Put in recipes; can track the amounts used; implies can have approximate calories out dishes (e.g. 5th approx for dinner, 5th approx for lunch tomorrow; implies track 'what was made last night' for an 'in the fridge' which you can clean out later)
- Tracking and graphs; Food Journal - keep track of everything
- Add in a suggestion system for things like hardcore exercise planning

# Exercise Considerations

[(1) Build in old @Home plan, Build in old RTe plan for @Gym, Build in RTe suggestions and recommendations to understandable suggestions]

[Need: Message to remind boost to protein + carbs; not intense suggestions]

# Meal Assistance Considerations
[Considering: Mapping in meals that are low calories, high protein and carbs at certain amounts (e.g. 200g carbs to create meal, 4 dishes implies 50g carbs in the dish; you needed to stay around 240g for the day)]

[Considering: When you put in a recipe it can try automatically get the calories on creation to make it easier to use as a quick calories tracking setup]

[Considering: How to make the map of reports work in an interactive way; e.g. state 'I want to keep track of my Carbs, Sugars, and Caffeine intake as well' and the small tracking assistance can do graphs on the reports]

# Logic Consideration for Model Structures
- Deleted flag is so you can find anything you removed in the past and get it back if you'd like.
- Names need to be unique (no whitespace before or after text, extra spaces removed so no '  ' to try make sure ' ' singles); not editable
- Exercise implies a normal exercise with description [e.g. 'sit-ups']
- Routine implies a set of exercises [e.g. 'tuesday: no weights; abs']
- RoutineLink implies which exercises are bound into a routine [e.g. 'tuesday...' has 'link' to 'amount 20' 'situps' in order position '1', it can have 'special' notes to say 'hold halfway at end for as long as you can' for whichever odd reason]
- RoutineTracking is what gets created when you start to do a Routine - if you force close the app before the end is reached it will count it as 'incomplete' in logs [e.g. it loads the routine with links and exercises and steps through it for you; when you are done it marks the 'when_ended' and was automatically updating the generated 'document' a simple html layout view]

[calories data came from https://tools.myfooddata.com/nutrition-facts-database-spreadsheet.php - tiny data adjustment was needed for CF dataset; still a large set so will take 'time', so to speak, to import; need to consider it more I think]

- Used: The Harris?Benedict equations revised by Mifflin and St Jeor in 1990
- Calories count Male: (10 x Weight)+(6.25 x HeightCm)-(5 x Age)+5
- Calories count Female: (10 x Weight)+(6.25 x HeightCm)-(5 x Age)-161
- Will use: '(10 x Weight)+(6.25 x HeightCm)-(5 x Age)-83' as a mid point - this isn't meant to be 100% perfect plan, everyone needs to manage it themselves, rather a good suggestive plan

[TODO: make the Calories count 'editable' so you can put in your own amount; or adjust the calculation for yourself accordingly; will be fixed for now]

[Note: see 'Issues in Dietary Use' - https://en.wikipedia.org/wiki/Harris%E2%80%93Benedict_equation ; need to work out the BMI side a bit - it implies the need to raise the count if you're underweight and reduce the count if you're overweight, I believe - doing research]

- Keep intake high: Protein + Carbs
- Avoid: Sugary beverages, baked food such as cookies or pastries, french fries, restuarant hamburgers from fast food restuarants, crackers or chips, white pasta or white bread, white rice, energy and granola bars, candied dried fruits, sweetened yoghurt, ice cream, processed meat, try stick to moderation for alcohol, candy bars
- Goal: This isn't to tell you what you shouldn't have in your diet; rather assist you in 'watching' your diet for yourself. For this reason, reports will be very simplified - the aim is to try help you follow a good routine of income, etc. Kinda why I want to make this possible to manage recipes as it can become the 'one stop shop' for knowledge needed in this regard

[Logic flaw: it's lovely to get the calories information with ease for things, but it isn't super successful. I would believe I need to put in the data interaction to 'add your own' but also how do we properly track things here? I don't want to have to weight each portion of the food I'm eating to generate a viable number here. It will work with the recipe interaction, but I figure it should be a ball-park use for calories tracking]

# Ideas Cancelled
- possibly store photos in app DB
- Spotify
- Relaxed version - you choose the 'intense' Routine, or a 'relaxed' routine; manage them yourse;
- Suggestion protein + carbs you have after exercise; will just be 'Remember to boost your protein and carbs a little' message after