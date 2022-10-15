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
- Muscle Grouping most likely helps with usability [see (2) below]

Personal Calories Tracking with which is meant to build the habit of not constantly eating 'too much'; more an assistant than a hardcore food management system
- Put in recipes; can track the amounts used; implies can have approximate calories out dishes (e.g. 5th approx for dinner, 5th approx for lunch tomorrow; implies track 'what was made last night' for an 'in the fridge' which you can clean out later)
- Tracking and graphs; Food Journal - keep track of everything
- Add in a suggestion system for things like hardcore exercise planning

# Exercise Considerations
[Considering: possibly store photos in app DB; might make it a little painful for sharing, though]

[(1) Build in old @Home plan, Build in old RTe plan for @Gym, Build in RTe suggestions and recommendations to understandable suggestions]

[Considering: There's a suggestion for protein + carbs intake around 15 minutes after exercises; should I build it in here on reminders, etc?]

[Considering: Add in 'relaxed' exercises to use; as in if you have an injury and don't feel like hardcore exercise can do some yoga, perhaps, or small activities?]

[(2) main areas: Upper (arms, shoulders, upper back), Lower (legs, glutes), Core (upper abdominal, lower abdominal, back), Cardio (moving exercises), Flexibility (stretches)]

# Meal Assistance Considerations
[Considering: Mapping in meals that are low calories, high protein and carbs at certain amounts (e.g. 200g carbs to create meal, 4 dishes implies 50g carbs in the dish; you needed to stay around 240g for the day)]

[Considering: When you put in a recipe it can try automatically get the calories on creation to make it easier to use as a quick calories tracking setup]

[Considering: How to make the map of reports work in an interactive way; e.g. state 'I want to keep track of my Carbs, Sugars, and Caffeine intake as well' and the small tracking assistance can do graphs on the reports]

[Need: Methods to convert liquids from grams to cup, etc when putting in data - e.g. 100g drink approximate at around 235g in calcs for a cup. Intended purpose - can click '1 cup' instead of putting in approximate amounts for ease]

[Need: Add spotify, experiment with https://github.com/JohnnyCrazy/SpotifyAPI-NET ]

# Logic Consideration for Model Structures
- Deleted flag is so you can find anything you removed in the past and get it back if you'd like.
- Names need to be unique (no whitespace before or after text, extra spaces removed so no '  ' to try make sure ' ' singles); not editable
- Exercise implies a normal exercise with description [e.g. 'sit-ups']
- Routine implies a set of exercises [e.g. 'tuesday: no weights; abs']
- RoutineLink implies which exercises are bound into a routine [e.g. 'tuesday...' has 'link' to 'amount 20' 'situps' in order position '1', it can have 'special' notes to say 'hold halfway at end for as long as you can' for whichever odd reason]
- RoutineTracking is what gets created when you start to do a Routine - if you force close the app before the end is reached it will count it as 'incomplete' in logs [e.g. it loads the routine with links and exercises and steps through it for you; when you are done it marks the 'when_ended' and was automatically updating the generated 'document' a simple html layout view]

[calories data came from https://tools.myfooddata.com/nutrition-facts-database-spreadsheet.php - tiny data adjustment was needed for CF dataset; still a large set so will take 'time', so to speak, to import]

[calories calculations came from https://www.livestrong.com/article/317684-how-many-calories-should-i-be-eating-for-my-height/ - see calculation; it isn't meant to be the most hardcore diet creation for you; rather to suggest and help you watch your habits]
- 9.99 x weight in kilograms + 6.25 x height in centimeters – 4.92 x age
- Keep intake high: Protein + Carbs
- Avoid: Sugary beverages, baked food such as cookies or pastries, french fries, restuarant hamburgers from fast food restuarants, crackers or chips, white pasta or white bread, white rice, energy and granola bars, candied dried fruits, sweetened yoghurt, ice cream, processed meat, try stick to moderation for alcohol, candy bars
- Goal: This isn't to tell you what you shouldn't have in your diet; rather assist you in 'watching' your diet for yourself. For this reason, reports will be very simplified - the aim is to try help you follow a good routine of income, etc. Kinda why I want to make this possible to manage recipes as it can become the 'one stop shop' for knowledge needed in this regard