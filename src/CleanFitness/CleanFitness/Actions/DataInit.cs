using Android.Graphics;
using CleanFitness.Models;
using Java.IO;
using Java.Util;
using System;
using System.Collections.Generic;
using System.IO;

namespace CleanFitness.Actions;

public static class DataInit
{
    public static void DB(DB DB, Dictionary<string, string> images)
    {
        // Exercises
        #region EXERCISES
        //  - Bodyweight
        DB.Insert(new MExercise()
        {
            Name = "Standing Burpees",
            Description = "",
            RequiredEquipment = "",
            Image = "img_burpees.png"
        });
        DB.Insert(new MExercise()
        {
            Name = "Standing Jump Squats",
            Description = "",
            RequiredEquipment = "",
            Image = "img_jump_squats.png"
        });
        DB.Insert(new MExercise()
        {
            Name = "Floor Reverse Crunch",
            Description = "",
            RequiredEquipment = "",
            Image = "img_reverse_crunch.png"
        });
        DB.Insert(new MExercise()
        {
            Name = "Floor Bicycle Crunch",
            Description = "",
            RequiredEquipment = "",
            Image = "img_bicycle_crunch.png"
        });
        DB.Insert(new MExercise()
        {
            Name = "Standing Pull Up",
            Description = "",
            RequiredEquipment = "",
            Image = "img_pull_ups.png"
        });
        DB.Insert(new MExercise()
        {
            Name = "Tricep Dips",
            Description = "",
            RequiredEquipment = "",
            Image = "img_tricep_dip.png"
        });
        DB.Insert(new MExercise()
        {
            Name = "Floor Side Plank",
            Description = "",
            RequiredEquipment = "",
            Image = "img_side_plank.png"
        });
        DB.Insert(new MExercise()
        {
            Name = "Floor Diamond Push Ups",
            Description = "",
            RequiredEquipment = "",
            Image = "img_diamond_push_up.png"
        });
        DB.Insert(new MExercise()
        {
            Name = "Floor Mountain Climbers",
            Description = "",
            RequiredEquipment = "",
            Image = "img_mountain_climbers.png"
        });
        DB.Insert(new MExercise()
        {
            Name = "Floor Glute Bridge",
            Description = "",
            RequiredEquipment = "",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Standing Forward Lunge",
            Description = "",
            RequiredEquipment = "",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Standing Y Squats",
            Description = "",
            RequiredEquipment = "",
            Image = "img_y_squats.png"
        });
        DB.Insert(new MExercise()
        {
            Name = "Standing Lateral Squat",
            Description = "",
            RequiredEquipment = "",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Standing Shoulder Taps",
            Description = "",
            RequiredEquipment = "",
            Image = "img_shoulder_taps.png"
        });
        DB.Insert(new MExercise()
        {
            Name = "Standing Back Extensions",
            Description = "",
            RequiredEquipment = "",
            Image = "img_back_extension.png"
        });
        DB.Insert(new MExercise()
        {
            Name = "Standing Elbow to Knee",
            Description = "",
            RequiredEquipment = "",
            Image = "img_elbow_to_knee.png"
        });
        DB.Insert(new MExercise()
        {
            Name = "Floor Push Up",
            Description = "",
            RequiredEquipment = "",
            Image = "img_push_ups.png"
        });
        DB.Insert(new MExercise()
        {
            Name = "Standing Bodyweight Scissors",
            Description = "",
            RequiredEquipment = "",
            Image = "img_scissors.png"
        });
        DB.Insert(new MExercise()
        {
            Name = "Standing Jump Squats",
            Description = "",
            RequiredEquipment = "",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Floor Plank to Push Up",
            Description = "",
            RequiredEquipment = "",
            Image = "img_plank_to_pushups.png"
        });
        DB.Insert(new MExercise()
        {
            Name = "Floor T Push Up",
            Description = "",
            RequiredEquipment = "",
            Image = "img_t_push_up.png"
        });
        DB.Insert(new MExercise()
        {
            Name = "Floor V Push Up",
            Description = "",
            RequiredEquipment = "",
            Image = "img_v_push_ups.png"
        });
        DB.Insert(new MExercise()
        {
            Name = "Standing Jumping Jacks",
            Description = "",
            RequiredEquipment = "",
            Image = "img_jumping_jacks.png"
        });


        //  - Dumbbells
        DB.Insert(new MExercise()
        {
            Name = "Push Up with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Renegade Row Push Ups with Dumbbells",
            RequiredEquipment = "Dumbbells",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "T Push Up with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Floor Press with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Bent Over Row with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "High Pulls with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Shoulder Shrugs with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Reverse Grip Bent Over Row with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Bent Over Fly with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Renegade Row with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Side Deltoid Raise",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Bicep Curls with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Bicep Curl to Shoulder Press",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Hammer Curls with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Tricep Extension with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Side Plank with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "img_side_plank.png"
        });
        DB.Insert(new MExercise()
        {
            Name = "Russian Twist with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Jump Squat with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Weighted Squat with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Squat to Curl to Press",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Sumo Squat with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Rotating Dumbbell Squat Press",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Lunges with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "img_lunge.png"
        });
        DB.Insert(new MExercise()
        {
            Name = "Lunge to Press with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Side Lunge with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Reverse Lunge with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Step Up with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Shoulder Press with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Alternating Shoulder Press with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Arnold's Shoulder Press with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Push Press with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Lateral Raises with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Front Raises with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Front/Lateral Raises with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Halo with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "One Arm Snatch with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Wood Chopper/Chipper with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        });


        //  - Barbells
        DB.Insert(new MExercise()
        {
            Name = "Barbbell Roll-Outs",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Flat Barbell Bench Press",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Incline Barbell Bench Press",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Decline Barbell Bench Press",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Close-Grip Barbell Bench Press",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Standing Barbell Bicep Curl",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Seated Barbell Preacher Curl",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Incline Barbell Spider Curl",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Standing Reverse Grip Barbell Curls",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Barbell Flat Bench Skull Crushers",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Barbell Incline Skull Crushers",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Barbell Overhead Tricep Extension",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Standing Barbell Overhead Press",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Standing Barbell Behind the Neck Press",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Standing Barbell Push Press",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Seated Barbell Z Press",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Seated Barbell Shoulder Press",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Standing Barbell Yates Row",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Standing Barbell Shrug",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Standing Barbell Upright Row",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Flat Barbell Pullover",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Flat Barbell Glute Bridge",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = "img_flute_bridge.png"
        });
        DB.Insert(new MExercise()
        {
            Name = "Standing Barbell Romanian Deadlift",
            Description = "",
            RequiredEquipment = "",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Standing Barbell Good Morning",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Standing Barbell Back Squat",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Standing Barbell Front Squat",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Seated Barbell Calf Raises",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Standing Barbell Calf Raises",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        });

        //  - Other
        DB.Insert(new MExercise()
        {
            Name = "Walk on Treadmill",
            Description = "",
            RequiredEquipment = "Treadmill",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Brisk Walk on Treadmill",
            Description = "",
            RequiredEquipment = "Treadmill",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Jog on Treadmill",
            Description = "",
            RequiredEquipment = "Treadmill",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Stationary Bicycle",
            Description = "",
            RequiredEquipment = "Stationary Bicycle",
            Image = ""
        });
        DB.Insert(new MExercise()
        {
            Name = "Rowing Machine",
            Description = "",
            RequiredEquipment = "Rowing Machine",
            Image = ""
        });
        #endregion
        var exercises = DB.Get<MExercise>(a => true);

        // Routines

    }
}
