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
        var exercise_standing_burpees = new MExercise()
        {
            Name = "Standing Burpees",
            Description = "",
            RequiredEquipment = "",
            Image = "img_burpees.png"
        };
        DB.Insert(exercise_standing_burpees);

        var exercise_plank = new MExercise()
        {
            Name = "Floor Plank",
            Description = "",
            RequiredEquipment = "",
            Image = ""
        };
        DB.Insert(exercise_plank);

        var exercise_standing_jump_squats = new MExercise()
        {
            Name = "Standing Jump Squats",
            Description = "",
            RequiredEquipment = "",
            Image = "img_jump_squats.png"
        };
        DB.Insert(exercise_standing_jump_squats);

        var exercise_floor_reverse_crunch = new MExercise()
        {
            Name = "Floor Reverse Crunch",
            Description = "",
            RequiredEquipment = "",
            Image = "img_reverse_crunch.png"
        };
        DB.Insert(exercise_floor_reverse_crunch);

        var exercise_floor_vertical_crunch = new MExercise()
        {
            Name = "Floor Bicycle Crunch",
            Description = "",
            RequiredEquipment = "",
            Image = "img_bicycle_crunch.png"
        };
        DB.Insert(exercise_floor_vertical_crunch);

        var exercise_standing_pull_up = new MExercise()
        {
            Name = "Standing Pull Up",
            Description = "",
            RequiredEquipment = "",
            Image = "img_pull_ups.png"
        };
        DB.Insert(exercise_standing_pull_up);

        var exercise_tricep_dips = new MExercise()
        {
            Name = "Tricep Dips",
            Description = "",
            RequiredEquipment = "",
            Image = "img_tricep_dip.png"
        };
        DB.Insert(exercise_tricep_dips);

        var exercise_floor_side_plank = new MExercise()
        {
            Name = "Floor Side Plank",
            Description = "",
            RequiredEquipment = "",
            Image = "img_side_plank.png"
        };
        DB.Insert(exercise_floor_side_plank);

        var exercise_floor_diamond_pushups = new MExercise()
        {
            Name = "Floor Diamond Push Ups",
            Description = "",
            RequiredEquipment = "",
            Image = "img_diamond_push_up.png"
        };
        DB.Insert(exercise_floor_diamond_pushups);

        var exercise_floor_mountain_climbers = new MExercise()
        {
            Name = "Floor Mountain Climbers",
            Description = "",
            RequiredEquipment = "",
            Image = "img_mountain_climbers.png"
        };
        DB.Insert(exercise_floor_mountain_climbers);

        var exercise_floor_glute_bridge = new MExercise()
        {
            Name = "Floor Glute Bridge",
            Description = "",
            RequiredEquipment = "",
            Image = ""
        };
        DB.Insert(exercise_floor_glute_bridge);

        var exercise_standing_forward_lunges = new MExercise()
        {
            Name = "Standing Forward Lunge",
            Description = "",
            RequiredEquipment = "",
            Image = ""
        };
        DB.Insert(exercise_standing_forward_lunges);

        var exercise_standing_y_squats = new MExercise()
        {
            Name = "Standing Y Squats",
            Description = "",
            RequiredEquipment = "",
            Image = "img_y_squats.png"
        };
        DB.Insert(exercise_standing_y_squats);

        var exercise_standing_lateral_squat = new MExercise()
        {
            Name = "Standing Lateral Squat",
            Description = "",
            RequiredEquipment = "",
            Image = ""
        };
        DB.Insert(exercise_standing_lateral_squat);

        var exercise_standing_shoulder_taps = new MExercise()
        {
            Name = "Standing Shoulder Taps",
            Description = "",
            RequiredEquipment = "",
            Image = "img_shoulder_taps.png"
        };
        DB.Insert(exercise_standing_shoulder_taps);

        var exercise_standing_back_extensions = new MExercise()
        {
            Name = "Standing Back Extensions",
            Description = "",
            RequiredEquipment = "",
            Image = "img_back_extension.png"
        };
        DB.Insert(exercise_standing_back_extensions);

        var exercise_standing_elbow_to_knee = new MExercise()
        {
            Name = "Standing Elbow to Knee",
            Description = "",
            RequiredEquipment = "",
            Image = "img_elbow_to_knee.png"
        };
        DB.Insert(exercise_standing_elbow_to_knee);

        var exercise_floor_push_up = new MExercise()
        {
            Name = "Floor Push Up",
            Description = "",
            RequiredEquipment = "",
            Image = "img_push_ups.png"
        };
        DB.Insert(exercise_floor_push_up);

        var exercise_standing_bodyweight_scissors = new MExercise()
        {
            Name = "Standing Bodyweight Scissors",
            Description = "",
            RequiredEquipment = "",
            Image = "img_scissors.png"
        };
        DB.Insert(exercise_standing_bodyweight_scissors);

        var exercise_floor_plank_to_pushup = new MExercise()
        {
            Name = "Floor Plank to Push Up",
            Description = "",
            RequiredEquipment = "",
            Image = "img_plank_to_pushups.png"
        };
        DB.Insert(exercise_floor_plank_to_pushup);

        var exercise_floor_t_push_up = new MExercise()
        {
            Name = "Floor T Push Up",
            Description = "",
            RequiredEquipment = "",
            Image = "img_t_push_up.png"
        };
        DB.Insert(exercise_floor_t_push_up);

        var exercise_floor_v_push_up = new MExercise()
        {
            Name = "Floor V Push Up",
            Description = "",
            RequiredEquipment = "",
            Image = "img_v_push_ups.png"
        };
        DB.Insert(exercise_floor_v_push_up);

        var exercise_standing_jumping_jacks = new MExercise()
        {
            Name = "Standing Jumping Jacks",
            Description = "",
            RequiredEquipment = "",
            Image = "img_jumping_jacks.png"
        };
        DB.Insert(exercise_standing_jumping_jacks);


        //  - Dumbbells
        var exercise_push_up_with_dumbbells = new MExercise()
        {
            Name = "Push Up with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        };
        DB.Insert(exercise_push_up_with_dumbbells);

        var exercise_renegade_row_push_up_with_dumbbells = new MExercise()
        {
            Name = "Renegade Row Push Ups with Dumbbells",
            RequiredEquipment = "Dumbbells",
            Image = ""
        };
        DB.Insert(exercise_renegade_row_push_up_with_dumbbells);

        var exercise_t_push_up_with_dumbbells = new MExercise()
        {
            Name = "T Push Up with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        };
        DB.Insert(exercise_t_push_up_with_dumbbells);

        var exercise_floor_press_with_dumbbells = new MExercise()
        {
            Name = "Floor Press with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        };
        DB.Insert(exercise_floor_press_with_dumbbells);

        var exercise_bent_over_row_with_dumbbells = new MExercise()
        {
            Name = "Bent Over Row with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        };
        DB.Insert(exercise_bent_over_row_with_dumbbells);

        var exercise_high_pulls_with_dumbbells = new MExercise()
        {
            Name = "High Pulls with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        };
        DB.Insert(exercise_high_pulls_with_dumbbells);

        var exercise_shoulder_shrugs_with_dumbbells = new MExercise()
        {
            Name = "Shoulder Shrugs with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        };
        DB.Insert(exercise_shoulder_shrugs_with_dumbbells);

        var exercise_reverse_grip_bent_over_row_with_dumbbells = new MExercise()
        {
            Name = "Reverse Grip Bent Over Row with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        };
        DB.Insert(exercise_reverse_grip_bent_over_row_with_dumbbells);

        var exercise_bent_over_fly_with_dumbbells = new MExercise()
        {
            Name = "Bent Over Fly with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        };
        DB.Insert(exercise_bent_over_fly_with_dumbbells);

        var exercise_renegade_row_with_dumbbells = new MExercise()
        {
            Name = "Renegade Row with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        };
        DB.Insert(exercise_renegade_row_with_dumbbells);

        var exercise_side_deltoid_raise = new MExercise()
        {
            Name = "Side Deltoid Raise",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        };
        DB.Insert(exercise_side_deltoid_raise);

        var exercise_bicep_curls_with_dumbbells = new MExercise()
        {
            Name = "Bicep Curls with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        };
        DB.Insert(exercise_bicep_curls_with_dumbbells);

        var exercise_bicep_curl_to_shoulder_press = new MExercise()
        {
            Name = "Bicep Curl to Shoulder Press",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        };
        DB.Insert(exercise_bicep_curl_to_shoulder_press);

        var exercise_hammer_curls_with_dumbbells = new MExercise()
        {
            Name = "Hammer Curls with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        };
        DB.Insert(exercise_hammer_curls_with_dumbbells);

        var exercise_tricep_extension_with_dumbbells = new MExercise()
        {
            Name = "Tricep Extension with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        };
        DB.Insert(exercise_tricep_extension_with_dumbbells);

        var exercise_side_plank_with_dumbbells = new MExercise()
        {
            Name = "Side Plank with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "img_side_plank.png"
        };
        DB.Insert(exercise_side_plank_with_dumbbells);

        var exercise_russian_twist_with_dumbbells = new MExercise()
        {
            Name = "Russian Twist with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        };
        DB.Insert(exercise_russian_twist_with_dumbbells);

        var exercise_jump_squat_with_dumbbells = new MExercise()
        {
            Name = "Jump Squat with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        };
        DB.Insert(exercise_jump_squat_with_dumbbells);

        var exercise_weighted_squat_with_dumbbells = new MExercise()
        {
            Name = "Weighted Squat with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        };
        DB.Insert(exercise_weighted_squat_with_dumbbells);

        var exercise_squat_to_curl_to_press = new MExercise()
        {
            Name = "Squat to Curl to Press",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        };
        DB.Insert(exercise_squat_to_curl_to_press);

        var exercise_sumo_squat_with_dumbbells = new MExercise()
        {
            Name = "Sumo Squat with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        };
        DB.Insert(exercise_sumo_squat_with_dumbbells);

        var exercise_rorating_dumbbell_squat_press = new MExercise()
        {
            Name = "Rotating Dumbbell Squat Press",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        };
        DB.Insert(exercise_rorating_dumbbell_squat_press);

        DB.Insert(new MExercise()
        {
            Name = "Lunges with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "img_lunge.png"
        });

        var exercise_lunge_to_press_with_dumbbells = new MExercise()
        {
            Name = "Lunge to Press with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        };
        DB.Insert(exercise_lunge_to_press_with_dumbbells);

        var exercise_side_lunge_with_dumbbells = new MExercise()
        {
            Name = "Side Lunge with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        };
        DB.Insert(exercise_side_lunge_with_dumbbells);

        var exercise_reverse_lunge_with_dumbbells = new MExercise()
        {
            Name = "Reverse Lunge with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        };
        DB.Insert(exercise_reverse_lunge_with_dumbbells);

        var exercise_step_up_with_dumbbells = new MExercise()
        {
            Name = "Step Up with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        };
        DB.Insert(exercise_step_up_with_dumbbells);

        var exercise_shoulder_press_with_dumbbells = new MExercise()
        {
            Name = "Shoulder Press with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        };
        DB.Insert(exercise_shoulder_press_with_dumbbells);

        var exercise_alternating_shoulder_press_with_dumbbells = new MExercise()
        {
            Name = "Alternating Shoulder Press with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        };
        DB.Insert(exercise_alternating_shoulder_press_with_dumbbells);

        var exercise_arnolds_shoulder_press_with_dumbbells = new MExercise()
        {
            Name = "Arnold's Shoulder Press with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        };
        DB.Insert(exercise_arnolds_shoulder_press_with_dumbbells);

        var exercise_push_press_with_dumbbells = new MExercise()
        {
            Name = "Push Press with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        };
        DB.Insert(exercise_push_press_with_dumbbells);

        var exercise_lateral_raises_with_dumbbells = new MExercise()
        {
            Name = "Lateral Raises with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        };
        DB.Insert(exercise_lateral_raises_with_dumbbells);

        var exercise_front_raises_with_dumbbells = new MExercise()
        {
            Name = "Front Raises with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        };
        DB.Insert(exercise_front_raises_with_dumbbells);

        var exercise_front_lateral_raises_with_dumbbells = new MExercise()
        {
            Name = "Front/Lateral Raises with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        };
        DB.Insert(exercise_front_lateral_raises_with_dumbbells);

        var exercise_halo_with_dumbbells = new MExercise()
        {
            Name = "Halo with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        };
        DB.Insert(exercise_halo_with_dumbbells);

        var exercise_one_arm_snatch_with_dumbbells = new MExercise()
        {
            Name = "One Arm Snatch with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        };
        DB.Insert(exercise_one_arm_snatch_with_dumbbells);

        var exercise_wood_chopper_chipper_with_dumbbells = new MExercise()
        {
            Name = "Wood Chopper/Chipper with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = ""
        };
        DB.Insert(exercise_wood_chopper_chipper_with_dumbbells);


        //  - Barbells
        var exercise_barbell_rollouts = new MExercise()
        {
            Name = "Barbbell Roll-Outs",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        };
        DB.Insert(exercise_barbell_rollouts);

        var exercise_flat_barbell_bench_press = new MExercise()
        {
            Name = "Flat Barbell Bench Press",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        };
        DB.Insert(exercise_flat_barbell_bench_press);

        var exercise_incline_barbell_bench_press = new MExercise()
        {
            Name = "Incline Barbell Bench Press",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        };
        DB.Insert(exercise_incline_barbell_bench_press);

        var exercise_decline_barbell_bench_press = new MExercise()
        {
            Name = "Decline Barbell Bench Press",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        };
        DB.Insert(exercise_decline_barbell_bench_press);

        var exercise_cross_grip_barbell_bench_press = new MExercise()
        {
            Name = "Close-Grip Barbell Bench Press",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        };
        DB.Insert(exercise_cross_grip_barbell_bench_press);

        var exercise_standing_barbell_bicep_curl = new MExercise()
        {
            Name = "Standing Barbell Bicep Curl",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        };
        DB.Insert(exercise_standing_barbell_bicep_curl);

        var exercise_seated_barbell_preacher_curl = new MExercise()
        {
            Name = "Seated Barbell Preacher Curl",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        };
        DB.Insert(exercise_seated_barbell_preacher_curl);

        var exercise_incline_barbell_spider_curl = new MExercise()
        {
            Name = "Incline Barbell Spider Curl",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        };
        DB.Insert(exercise_incline_barbell_spider_curl);

        var exercise_standing_reverse_grip_barbell_curls = new MExercise()
        {
            Name = "Standing Reverse Grip Barbell Curls",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        };
        DB.Insert(exercise_standing_reverse_grip_barbell_curls);

        var exercise_barbell_flat_bench_skull_crushers = new MExercise()
        {
            Name = "Barbell Flat Bench Skull Crushers",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        };
        DB.Insert(exercise_barbell_flat_bench_skull_crushers);

        var exercise_barbell_incline_skull_crushers = new MExercise()
        {
            Name = "Barbell Incline Skull Crushers",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        };
        DB.Insert(exercise_barbell_incline_skull_crushers);

        var exercise_barbell_overhead_tricep_extension = new MExercise()
        {
            Name = "Barbell Overhead Tricep Extension",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        };
        DB.Insert(exercise_barbell_overhead_tricep_extension);

        var exercise_standing_barbell_overhead_press = new MExercise()
        {
            Name = "Standing Barbell Overhead Press",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        };
        DB.Insert(exercise_standing_barbell_overhead_press);

        var exercise_standing_barbell_behind_the_neck_press = new MExercise()
        {
            Name = "Standing Barbell Behind the Neck Press",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        };
        DB.Insert(exercise_standing_barbell_behind_the_neck_press);

        var exercise_standing_barbell_push_press = new MExercise()
        {
            Name = "Standing Barbell Push Press",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        };
        DB.Insert(exercise_standing_barbell_push_press);

        var exercise_standing_barbell_z_press = new MExercise()
        {
            Name = "Seated Barbell Z Press",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        };
        DB.Insert(exercise_standing_barbell_z_press);

        var exercise_seated_barbell_shoulder_press = new MExercise()
        {
            Name = "Seated Barbell Shoulder Press",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        };
        DB.Insert(exercise_seated_barbell_shoulder_press);

        var exercise_standing_barbell_yates_row = new MExercise()
        {
            Name = "Standing Barbell Yates Row",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        };
        DB.Insert(exercise_standing_barbell_yates_row);

        var exercise_standing_barbell_shrug = new MExercise()
        {
            Name = "Standing Barbell Shrug",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        };
        DB.Insert(exercise_standing_barbell_shrug);

        var exercise_standing_barbell_upright_row = new MExercise()
        {
            Name = "Standing Barbell Upright Row",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        };
        DB.Insert(exercise_standing_barbell_upright_row);

        var exercise_flat_barbell_pullover = new MExercise()
        {
            Name = "Flat Barbell Pullover",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        };
        DB.Insert(exercise_flat_barbell_pullover);

        var exercise_flat_barbell_glute_bridge = new MExercise()
        {
            Name = "Flat Barbell Glute Bridge",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = "img_flute_bridge.png"
        };
        DB.Insert(exercise_flat_barbell_glute_bridge);

        var exercise_Standing_barbell_romanian_deadlift = new MExercise()
        {
            Name = "Standing Barbell Romanian Deadlift",
            Description = "",
            RequiredEquipment = "",
            Image = ""
        };
        DB.Insert(exercise_Standing_barbell_romanian_deadlift);

        var exercise_standing_barbell_good_morning = new MExercise()
        {
            Name = "Standing Barbell Good Morning",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        };
        DB.Insert(exercise_standing_barbell_good_morning);

        var exercise_standing_barbell_back_squat = new MExercise()
        {
            Name = "Standing Barbell Back Squat",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        };
        DB.Insert(exercise_standing_barbell_back_squat);

        var exercise_standing_barbell_front_squat = new MExercise()
        {
            Name = "Standing Barbell Front Squat",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        };
        DB.Insert(exercise_standing_barbell_front_squat);

        var exercise_seated_barbell_Calf_raises = new MExercise()
        {
            Name = "Seated Barbell Calf Raises",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        };
        DB.Insert(exercise_seated_barbell_Calf_raises);

        var exercise_standing_barbell_calf_raises = new MExercise()
        {
            Name = "Standing Barbell Calf Raises",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = ""
        };
        DB.Insert(exercise_standing_barbell_calf_raises);

        //  - Other
        var exercise_walk_on_treadmill = new MExercise()
        {
            Name = "Walk on Treadmill",
            Description = "",
            RequiredEquipment = "Treadmill",
            Image = ""
        };
        DB.Insert(exercise_walk_on_treadmill);

        var exercise_brisk_walk_on_treadmill = new MExercise()
        {
            Name = "Brisk Walk on Treadmill",
            Description = "",
            RequiredEquipment = "Treadmill",
            Image = ""
        };
        DB.Insert(exercise_brisk_walk_on_treadmill);

        var exercise_run_on_treadmill = new MExercise()
        {
            Name = "Run on Treadmill",
            Description = "",
            RequiredEquipment = "Treadmill",
            Image = ""
        };
        DB.Insert(exercise_run_on_treadmill);

        var exercise_stationary_bicycle = new MExercise()
        {
            Name = "Stationary Bicycle",
            Description = "",
            RequiredEquipment = "Stationary Bicycle",
            Image = ""
        };
        DB.Insert(exercise_stationary_bicycle);

        var exercise_rowing_machine = new MExercise()
        {
            Name = "Rowing Machine",
            Description = "",
            RequiredEquipment = "Rowing Machine",
            Image = ""
        };
        DB.Insert(exercise_rowing_machine);
        #endregion

        // Routines
        List<MRoutineLink>? routineLinks;

        routineLinks = new List<MRoutineLink>();
        _InsertExercise(routineLinks, exercise_run_on_treadmill, "20 minutes", "Or take a 20 minute run.");
        BuildRoutine(DB, "Run on Treadmill", "Take a 20 minute run on a treadmill today.", false, false, false, false, false, false, false, false, routineLinks);

        routineLinks = new List<MRoutineLink>();
        _InsertExercise(routineLinks, exercise_walk_on_treadmill, "20 minutes", "Or take a 20 minute walk outisde.");
        BuildRoutine(DB, "Walk on Treadmill", "Take 20 minutes to walk on a tradmill today.", false, false, false, false, false, false, false, false, routineLinks);

        routineLinks = new List<MRoutineLink>();
        _InsertExercise(routineLinks, exercise_rowing_machine, "20 minutes", "");
        BuildRoutine(DB, "Use Rowing Machine", "Take 20 minutes to use the rowing machine today.", false, false, false, false, false, false, false, false, routineLinks);

        routineLinks = new List<MRoutineLink>();
        _InsertExercise(routineLinks, exercise_stationary_bicycle, "20 minutes", "");
        BuildRoutine(DB, "Use Stationary Bicycle", "Take 20 minutes to cycle today.", false, false, false, false, false, false, false, false, routineLinks);

        // Saturday, Wedneday: Rest Days - TODO: put in stretches options and such
        routineLinks = new List<MRoutineLink>();
        _InsertExercise(routineLinks, exercise_brisk_walk_on_treadmill, "20 minutes", "Or take a 20 minute brisk walk.");
        BuildRoutine(DB, "Brisk Walk on Treadmill", "Take 20 minutes to brisk walk on a treadmill today.", false, false, false, true, false, false, true, false, routineLinks);

        // Sunday: Medium effort - Arms/Shoulders
        routineLinks = new List<MRoutineLink>();
        _InsertExercise(routineLinks, exercise_brisk_walk_on_treadmill, "5-10 minutes", "");
        _InsertExercise(routineLinks, exercise_floor_push_up, "20 reps", ""); // TODO: rest times
        _InsertExercise(routineLinks, exercise_standing_pull_up, "10 reps", "");
        _InsertExercise(routineLinks, exercise_floor_push_up, "20 reps", "");
        _InsertExercise(routineLinks, exercise_standing_pull_up, "10 reps", "");
        _InsertExercise(routineLinks, exercise_plank, "60 seconds", ""); // TODO: revamp for time windows to use auto android voice
        BuildRoutine(DB, "Medium: Arms, Shoulders", "Small bodyweight exercises. You can do pull ups at trees if need be, remember that.", false, false, false, false, false, false, false, true, routineLinks);

        routineLinks = new List<MRoutineLink>();
        _InsertExercise(routineLinks, exercise_brisk_walk_on_treadmill, "5-10 minutes", "");
        _InsertExercise(routineLinks, exercise_floor_push_up, "20 reps", "");
        _InsertExercise(routineLinks, exercise_bicep_curls_with_dumbbells, "12 reps", "");
        _InsertExercise(routineLinks, exercise_lateral_raises_with_dumbbells, "12 reps", "");
        _InsertExercise(routineLinks, exercise_floor_push_up, "20 reps", "");
        _InsertExercise(routineLinks, exercise_bicep_curls_with_dumbbells, "12 reps", "");
        _InsertExercise(routineLinks, exercise_lateral_raises_with_dumbbells, "12 reps", "");
        _InsertExercise(routineLinks, exercise_plank, "60 seconds", "");
        BuildRoutine(DB, "Medium: Arms, Shoulders", "Less bodyweight, using Dumbbells to do a little more.", false, false, false, false, false, false, false, true, routineLinks);

        routineLinks = new List<MRoutineLink>();
        _InsertExercise(routineLinks, exercise_brisk_walk_on_treadmill, "5-10 minutes", "");
        _InsertExercise(routineLinks, exercise_floor_push_up, "20 reps", "");
        _InsertExercise(routineLinks, exercise_incline_barbell_bench_press, "10 reps", "Can be dumbbells.");
        _InsertExercise(routineLinks, exercise_incline_barbell_bench_press, "10 reps", "Can be dumbbells.");
        _InsertExercise(routineLinks, exercise_incline_barbell_bench_press, "10 reps", "Can be dumbbells.");
        _InsertExercise(routineLinks, exercise_incline_barbell_bench_press, "10 reps", "Can be dumbbells.");
        _InsertExercise(routineLinks, exercise_floor_push_up, "20 reps", "");
        _InsertExercise(routineLinks, exercise_front_lateral_raises_with_dumbbells, "12 reps", "6 each side.");
        _InsertExercise(routineLinks, exercise_front_lateral_raises_with_dumbbells, "12 reps", "6 each side.");
        _InsertExercise(routineLinks, exercise_front_lateral_raises_with_dumbbells, "12 reps", "6 each side.");
        _InsertExercise(routineLinks, exercise_front_lateral_raises_with_dumbbells, "12 reps", "6 each side.");
        _InsertExercise(routineLinks, exercise_floor_push_up, "20 reps", "");
        _InsertExercise(routineLinks, exercise_standing_barbell_overhead_press, "12 reps", "Can be dumbbells.");
        _InsertExercise(routineLinks, exercise_standing_barbell_overhead_press, "12 reps", "Can be dumbbells.");
        _InsertExercise(routineLinks, exercise_standing_barbell_overhead_press, "12 reps", "Can be dumbbells.");
        _InsertExercise(routineLinks, exercise_standing_barbell_overhead_press, "12 reps", "Can be dumbbells.");
        _InsertExercise(routineLinks, exercise_plank, "60 seconds", "");
        BuildRoutine(DB, "Heavy: Arms, Shoudlers", "Mostly weighted exercise, focus on upper arms and shoulders.", false, false, false, false, false, false, false, true, routineLinks);
        

        // Monday: Medium effort

        // Tueday: High effort

        // Thursday: Medium effort

        // Friday: High effort

    }

    private static void _InsertExercise(List<MRoutineLink> routineLinks, MExercise exercise, string amount, string special)
    {
        routineLinks.Add(new MRoutineLink()
        {
            Amount = amount,
            ExerciseId = exercise.Id,
            Special = special,
            // OrderNumber  automated
            // RoutineId automated
        });
    }

    public static void BuildRoutine(DB db, string name, string description, bool _sunday, bool _monday, bool _tuesday, bool _wednesday, bool _thursday, bool _friday, bool _saturday, bool _empty, List<MRoutineLink> mRoutineLinks)
    {
        var newRoutine = new MRoutine()
        {
            Name = name,
            Description = description,
            Day_Sunday = _sunday,
            Day_Monday = _monday,
            Day_Tuesday = _tuesday,
            Day_Wednesday = _wednesday,
            Day_Thursday = _thursday,
            Day_Friday = _friday,
            Day_Saturday = _saturday,
            Day_Empty = _empty
        };
        db.Insert(newRoutine);

        var i = 0;
        mRoutineLinks.ForEach(a =>
        {
            a.RoutineId = newRoutine.Id;
            a.OrderNumber = ++i;
            db.Insert(a);
        });
    }
}
