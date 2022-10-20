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
            Image = "img_burpees.png",
            Type = ExerciseType.Timed
        };
        DB.Insert(exercise_standing_burpees);

        var exercise_plank = new MExercise()
        {
            Name = "Floor Plank",
            Description = "",
            RequiredEquipment = "",
            Image = "",
            Type = ExerciseType.Timed
        };
        DB.Insert(exercise_plank);

        var exercise_standing_jump_squats = new MExercise()
        {
            Name = "Standing Jump Squats",
            Description = "",
            RequiredEquipment = "",
            Image = "img_jump_squats.png",
            Type = ExerciseType.Timed
        };
        DB.Insert(exercise_standing_jump_squats);

        var exercise_floor_reverse_crunch = new MExercise()
        {
            Name = "Floor Reverse Crunch",
            Description = "",
            RequiredEquipment = "",
            Image = "img_reverse_crunch.png",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_floor_reverse_crunch);

        var exercise_floor_vertical_crunch = new MExercise()
        {
            Name = "Floor Vertical Crunch",
            Description = "",
            RequiredEquipment = "",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_floor_vertical_crunch);

        var exercise_floor_bicycle_crunch = new MExercise()
        {
            Name = "Floor Bicycle Crunch",
            Description = "",
            RequiredEquipment = "",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_floor_bicycle_crunch);

        var exercise_standing_pull_up = new MExercise()
        {
            Name = "Standing Pull Up",
            Description = "",
            RequiredEquipment = "",
            Image = "img_pull_ups.png",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_standing_pull_up);

        var exercise_tricep_dips = new MExercise()
        {
            Name = "Tricep Dips",
            Description = "",
            RequiredEquipment = "",
            Image = "img_tricep_dip.png",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_tricep_dips);

        var exercise_floor_side_plank = new MExercise()
        {
            Name = "Floor Side Plank",
            Description = "",
            RequiredEquipment = "",
            Image = "img_side_plank.png",
            Type = ExerciseType.Timed
        };
        DB.Insert(exercise_floor_side_plank);

        var exercise_floor_diamond_pushups = new MExercise()
        {
            Name = "Floor Diamond Push Ups",
            Description = "",
            RequiredEquipment = "",
            Image = "img_diamond_push_up.png",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_floor_diamond_pushups);

        var exercise_floor_mountain_climbers = new MExercise()
        {
            Name = "Floor Mountain Climbers",
            Description = "",
            RequiredEquipment = "",
            Image = "img_mountain_climbers.png",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_floor_mountain_climbers);

        var exercise_floor_glute_bridge = new MExercise()
        {
            Name = "Floor Glute Bridge",
            Description = "",
            RequiredEquipment = "",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_floor_glute_bridge);

        var exercise_standing_forward_lunges = new MExercise()
        {
            Name = "Standing Forward Lunge",
            Description = "",
            RequiredEquipment = "",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_standing_forward_lunges);

        var exercise_standing_y_squats = new MExercise()
        {
            Name = "Standing Y Squats",
            Description = "",
            RequiredEquipment = "",
            Image = "img_y_squats.png",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_standing_y_squats);

        var exercise_standing_lateral_squat = new MExercise()
        {
            Name = "Standing Lateral Squat",
            Description = "",
            RequiredEquipment = "",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_standing_lateral_squat);

        var exercise_standing_shoulder_taps = new MExercise()
        {
            Name = "Standing Shoulder Taps",
            Description = "",
            RequiredEquipment = "",
            Image = "img_shoulder_taps.png",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_standing_shoulder_taps);

        var exercise_standing_back_extensions = new MExercise()
        {
            Name = "Standing Back Extensions",
            Description = "",
            RequiredEquipment = "",
            Image = "img_back_extension.png",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_standing_back_extensions);

        var exercise_standing_elbow_to_knee = new MExercise()
        {
            Name = "Standing Elbow to Knee",
            Description = "",
            RequiredEquipment = "",
            Image = "img_elbow_to_knee.png",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_standing_elbow_to_knee);

        var exercise_floor_push_up = new MExercise()
        {
            Name = "Floor Push Up",
            Description = "",
            RequiredEquipment = "",
            Image = "img_push_ups.png",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_floor_push_up);

        var exercise_standing_bodyweight_scissors = new MExercise()
        {
            Name = "Standing Bodyweight Scissors",
            Description = "",
            RequiredEquipment = "",
            Image = "img_scissors.png",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_standing_bodyweight_scissors);

        var exercise_floor_plank_to_pushup = new MExercise()
        {
            Name = "Floor Plank to Push Up",
            Description = "",
            RequiredEquipment = "",
            Image = "img_plank_to_pushups.png",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_floor_plank_to_pushup);

        var exercise_floor_t_push_up = new MExercise()
        {
            Name = "Floor T Push Up",
            Description = "",
            RequiredEquipment = "",
            Image = "img_t_push_up.png",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_floor_t_push_up);

        var exercise_floor_v_push_up = new MExercise()
        {
            Name = "Floor V Push Up",
            Description = "",
            RequiredEquipment = "",
            Image = "img_v_push_ups.png",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_floor_v_push_up);

        var exercise_standing_jumping_jacks = new MExercise()
        {
            Name = "Standing Jumping Jacks",
            Description = "",
            RequiredEquipment = "",
            Image = "img_jumping_jacks.png",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_standing_jumping_jacks);

        var exercise_bear_crawl = new MExercise()
        {
            Name = "Floor Bear Crawl",
            Description = "",
            RequiredEquipment = "",
            Image = "",
            Type = ExerciseType.Timed
        };
        DB.Insert(exercise_bear_crawl);

        var exercise_floor_crunch = new MExercise()
        {
            Name = "Floor Crunch",
            Description = "",
            RequiredEquipment = "",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_floor_crunch);


        //  - Dumbbells
        var exercise_push_up_with_dumbbells = new MExercise()
        {
            Name = "Push Up with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_push_up_with_dumbbells);

        var exercise_renegade_row_push_up_with_dumbbells = new MExercise()
        {
            Name = "Renegade Row Push Ups with Dumbbells",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_renegade_row_push_up_with_dumbbells);

        var exercise_t_push_up_with_dumbbells = new MExercise()
        {
            Name = "T Push Up with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_t_push_up_with_dumbbells);

        var exercise_floor_press_with_dumbbells = new MExercise()
        {
            Name = "Floor Press with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_floor_press_with_dumbbells);

        var exercise_bent_over_row_with_dumbbells = new MExercise()
        {
            Name = "Bent Over Row with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_bent_over_row_with_dumbbells);

        var exercise_high_pulls_with_dumbbells = new MExercise()
        {
            Name = "High Pulls with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_high_pulls_with_dumbbells);

        var exercise_shoulder_shrugs_with_dumbbells = new MExercise()
        {
            Name = "Shoulder Shrugs with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_shoulder_shrugs_with_dumbbells);

        var exercise_reverse_grip_bent_over_row_with_dumbbells = new MExercise()
        {
            Name = "Reverse Grip Bent Over Row with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_reverse_grip_bent_over_row_with_dumbbells);

        var exercise_bent_over_fly_with_dumbbells = new MExercise()
        {
            Name = "Bent Over Fly with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_bent_over_fly_with_dumbbells);

        var exercise_renegade_row_with_dumbbells = new MExercise()
        {
            Name = "Renegade Row with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_renegade_row_with_dumbbells);

        var exercise_side_deltoid_raise = new MExercise()
        {
            Name = "Side Deltoid Raise",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_side_deltoid_raise);

        var exercise_standing_bicep_curls_with_dumbbells = new MExercise()
        {
            Name = "Standing Bicep Curls with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_standing_bicep_curls_with_dumbbells);

        var exercise_seated_bicep_curls_with_dumbbells = new MExercise()
        {
            Name = "Seated Bicep Curls with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_seated_bicep_curls_with_dumbbells);

        var exercise_bicep_curl_to_shoulder_press = new MExercise()
        {
            Name = "Bicep Curl to Shoulder Press",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_bicep_curl_to_shoulder_press);

        var exercise_hammer_curls_with_dumbbells = new MExercise()
        {
            Name = "Hammer Curls with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_hammer_curls_with_dumbbells);

        var exercise_tricep_extension_with_dumbbells = new MExercise()
        {
            Name = "Tricep Extension with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_tricep_extension_with_dumbbells);

        var exercise_side_plank_with_dumbbells = new MExercise()
        {
            Name = "Side Plank with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "img_side_plank.png",
            Type = ExerciseType.Timed
        };
        DB.Insert(exercise_side_plank_with_dumbbells);

        var exercise_russian_twist_with_dumbbells = new MExercise()
        {
            Name = "Russian Twist with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_russian_twist_with_dumbbells);

        var exercise_jump_squat_with_dumbbells = new MExercise()
        {
            Name = "Jump Squat with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_jump_squat_with_dumbbells);

        var exercise_weighted_squat_with_dumbbells = new MExercise()
        {
            Name = "Weighted Squat with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_weighted_squat_with_dumbbells);

        var exercise_squat_to_curl_to_press = new MExercise()
        {
            Name = "Squat to Curl to Press",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_squat_to_curl_to_press);

        var exercise_sumo_squat_with_dumbbells = new MExercise()
        {
            Name = "Sumo Squat with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_sumo_squat_with_dumbbells);

        var exercise_rorating_dumbbell_squat_press = new MExercise()
        {
            Name = "Rotating Dumbbell Squat Press",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_rorating_dumbbell_squat_press);

        DB.Insert(new MExercise()
        {
            Name = "Lunges with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "img_lunge.png",
            Type = ExerciseType.Set
        });

        var exercise_lunge_to_press_with_dumbbells = new MExercise()
        {
            Name = "Lunge to Press with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_lunge_to_press_with_dumbbells);

        var exercise_side_lunge_with_dumbbells = new MExercise()
        {
            Name = "Side Lunge with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_side_lunge_with_dumbbells);

        var exercise_reverse_lunge_with_dumbbells = new MExercise()
        {
            Name = "Reverse Lunge with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_reverse_lunge_with_dumbbells);

        var exercise_step_up_with_dumbbells = new MExercise()
        {
            Name = "Step Up with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_step_up_with_dumbbells);

        var exercise_shoulder_press_with_dumbbells = new MExercise()
        {
            Name = "Shoulder Press with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_shoulder_press_with_dumbbells);

        var exercise_alternating_shoulder_press_with_dumbbells = new MExercise()
        {
            Name = "Alternating Shoulder Press with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_alternating_shoulder_press_with_dumbbells);

        var exercise_arnolds_shoulder_press_with_dumbbells = new MExercise()
        {
            Name = "Arnold's Shoulder Press with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_arnolds_shoulder_press_with_dumbbells);

        var exercise_push_press_with_dumbbells = new MExercise()
        {
            Name = "Push Press with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_push_press_with_dumbbells);

        var exercise_lateral_raises_with_dumbbells = new MExercise()
        {
            Name = "Lateral Raises with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_lateral_raises_with_dumbbells);

        var exercise_front_raises_with_dumbbells = new MExercise()
        {
            Name = "Front Raises with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_front_raises_with_dumbbells);

        var exercise_front_lateral_raises_with_dumbbells = new MExercise()
        {
            Name = "Front/Lateral Raises with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_front_lateral_raises_with_dumbbells);

        var exercise_halo_with_dumbbells = new MExercise()
        {
            Name = "Halo with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_halo_with_dumbbells);

        var exercise_one_arm_snatch_with_dumbbells = new MExercise()
        {
            Name = "One Arm Snatch with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_one_arm_snatch_with_dumbbells);

        var exercise_wood_chopper_chipper_with_dumbbells = new MExercise()
        {
            Name = "Wood Chopper/Chipper with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_wood_chopper_chipper_with_dumbbells);

        var exercise_reverse_lateral_raise_with_dumbbells = new MExercise()
        {
            Name = "Standing Reverse Lateral Raise with Dumbbells",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_reverse_lateral_raise_with_dumbbells);

        var exercise_dumbbell_swing = new MExercise()
        {
            Name = "Dumbbell/Kettlebell Swing",
            Description = "",
            RequiredEquipment = "Dumbbells, Kettlebell",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_dumbbell_swing);

        var exercise_dumbbell_side_bend = new MExercise()
        {
            Name = "Dumbbell Side Bend",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_dumbbell_side_bend);

        var exercise_lunge_single_arm_row_with_dumbbell = new MExercise()
        {
            Name = "Lunge with Dumbbell Single Arm Row",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };

        var exercise_dumbbell_deadlift_to_bicep_curl = new MExercise()
        {
            Name = "Dumbbell Deadlift to Bicep Curl",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_dumbbell_deadlift_to_bicep_curl);

        var exercise_dumbbell_curtsy_lunge_to_upright_row = new MExercise()
        {
            Name = "Dumbbell Curtsy Lunge to Upright Row",
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_dumbbell_curtsy_lunge_to_upright_row);

        var exercise_dumbbell_bridge_with_curls = new MExercise()
        {
            Name = "Dumbbell Bridge with Curls", // Maybe, need a name
            Description = "",
            RequiredEquipment = "Dumbbells",
            Image = "",
            Type = ExerciseType.Set
        };


        //  - Barbells
        var exercise_barbell_rollouts = new MExercise()
        {
            Name = "Barbbell Roll-Outs",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_barbell_rollouts);

        var exercise_flat_barbell_bench_press = new MExercise()
        {
            Name = "Flat Barbell Bench Press",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_flat_barbell_bench_press);

        var exercise_incline_barbell_bench_press = new MExercise()
        {
            Name = "Incline Barbell Bench Press",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_incline_barbell_bench_press);

        var exercise_decline_barbell_bench_press = new MExercise()
        {
            Name = "Decline Barbell Bench Press",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_decline_barbell_bench_press);

        var exercise_cross_grip_barbell_bench_press = new MExercise()
        {
            Name = "Close-Grip Barbell Bench Press",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_cross_grip_barbell_bench_press);

        var exercise_standing_barbell_bicep_curl = new MExercise()
        {
            Name = "Standing Barbell Bicep Curl",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_standing_barbell_bicep_curl);

        var exercise_seated_barbell_preacher_curl = new MExercise()
        {
            Name = "Seated Barbell Preacher Curl",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_seated_barbell_preacher_curl);

        var exercise_incline_barbell_spider_curl = new MExercise()
        {
            Name = "Incline Barbell Spider Curl",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_incline_barbell_spider_curl);

        var exercise_standing_reverse_grip_barbell_curls = new MExercise()
        {
            Name = "Standing Reverse Grip Barbell Curls",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_standing_reverse_grip_barbell_curls);

        var exercise_barbell_flat_bench_skull_crushers = new MExercise()
        {
            Name = "Barbell Flat Bench Skull Crushers",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_barbell_flat_bench_skull_crushers);

        var exercise_barbell_incline_skull_crushers = new MExercise()
        {
            Name = "Barbell Incline Skull Crushers",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_barbell_incline_skull_crushers);

        var exercise_barbell_overhead_tricep_extension = new MExercise()
        {
            Name = "Barbell Overhead Tricep Extension",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_barbell_overhead_tricep_extension);

        var exercise_standing_barbell_overhead_press = new MExercise()
        {
            Name = "Standing Barbell Overhead Press",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_standing_barbell_overhead_press);

        var exercise_standing_barbell_behind_the_neck_press = new MExercise()
        {
            Name = "Standing Barbell Behind the Neck Press",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_standing_barbell_behind_the_neck_press);

        var exercise_standing_barbell_push_press = new MExercise()
        {
            Name = "Standing Barbell Push Press",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_standing_barbell_push_press);

        var exercise_standing_barbell_z_press = new MExercise()
        {
            Name = "Seated Barbell Z Press",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_standing_barbell_z_press);

        var exercise_seated_barbell_shoulder_press = new MExercise()
        {
            Name = "Seated Barbell Shoulder Press",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_seated_barbell_shoulder_press);

        var exercise_standing_barbell_yates_row = new MExercise()
        {
            Name = "Standing Barbell Yates Row",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_standing_barbell_yates_row);

        var exercise_standing_barbell_shrug = new MExercise()
        {
            Name = "Standing Barbell Shrug",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_standing_barbell_shrug);

        var exercise_standing_barbell_upright_row = new MExercise()
        {
            Name = "Standing Barbell Upright Row",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_standing_barbell_upright_row);

        var exercise_flat_barbell_pullover = new MExercise()
        {
            Name = "Flat Barbell Pullover",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_flat_barbell_pullover);

        var exercise_flat_barbell_glute_bridge = new MExercise()
        {
            Name = "Flat Barbell Glute Bridge",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = "img_flute_bridge.png",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_flat_barbell_glute_bridge);

        var exercise_Standing_barbell_romanian_deadlift = new MExercise()
        {
            Name = "Standing Barbell Romanian Deadlift",
            Description = "",
            RequiredEquipment = "",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_Standing_barbell_romanian_deadlift);

        var exercise_standing_barbell_good_morning = new MExercise()
        {
            Name = "Standing Barbell Good Morning",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_standing_barbell_good_morning);

        var exercise_standing_barbell_back_squat = new MExercise()
        {
            Name = "Standing Barbell Back Squat",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_standing_barbell_back_squat);

        var exercise_standing_barbell_front_squat = new MExercise()
        {
            Name = "Standing Barbell Front Squat",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_standing_barbell_front_squat);

        var exercise_seated_barbell_Calf_raises = new MExercise()
        {
            Name = "Seated Barbell Calf Raises",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_seated_barbell_Calf_raises);

        var exercise_standing_barbell_calf_raises = new MExercise()
        {
            Name = "Standing Barbell Calf Raises",
            Description = "",
            RequiredEquipment = "Barbell",
            Image = "",
            Type = ExerciseType.Set
        };
        DB.Insert(exercise_standing_barbell_calf_raises);

        //  - Other
        var exercise_walk_on_treadmill = new MExercise()
        {
            Name = "Walk on Treadmill",
            Description = "",
            RequiredEquipment = "Treadmill",
            Image = "",
            Type = ExerciseType.Timed
        };
        DB.Insert(exercise_walk_on_treadmill);

        var exercise_brisk_walk_on_treadmill = new MExercise()
        {
            Name = "Brisk Walk on Treadmill",
            Description = "",
            RequiredEquipment = "Treadmill",
            Image = "",
            Type = ExerciseType.Timed
        };
        DB.Insert(exercise_brisk_walk_on_treadmill);

        var exercise_run_on_treadmill = new MExercise()
        {
            Name = "Run on Treadmill",
            Description = "",
            RequiredEquipment = "Treadmill",
            Image = "",
            Type = ExerciseType.Timed
        };
        DB.Insert(exercise_run_on_treadmill);

        var exercise_stationary_bicycle = new MExercise()
        {
            Name = "Stationary Bicycle",
            Description = "",
            RequiredEquipment = "Stationary Bicycle",
            Image = "",
            Type = ExerciseType.Timed
        };
        DB.Insert(exercise_stationary_bicycle);

        var exercise_rowing_machine = new MExercise()
        {
            Name = "Rowing Machine",
            Description = "",
            RequiredEquipment = "Rowing Machine",
            Image = "",
            Type = ExerciseType.Timed
        };
        DB.Insert(exercise_rowing_machine);
        #endregion

        // TODO: Android voice setup
        // Routines
        List<MRoutineLink>? routineLinks;

        routineLinks = new List<MRoutineLink>();
        _InsertExercise(routineLinks, exercise_run_on_treadmill, "20 minutes", "Or take a 20 minute run.");
        BuildRoutine(DB, "Run on Treadmill", "Take a 20 minute run on a treadmill today.", false, false, false, false, false, false, false, false, routineLinks);

        routineLinks.Clear();
        _InsertExercise(routineLinks, exercise_walk_on_treadmill, "20 minutes", "Or take a 20 minute walk outisde.");
        BuildRoutine(DB, "Walk on Treadmill", "Take 20 minutes to walk on a tradmill today.", false, false, false, false, false, false, false, false, routineLinks);

        routineLinks.Clear();
        _InsertExercise(routineLinks, exercise_rowing_machine, "20 minutes", "");
        BuildRoutine(DB, "Use Rowing Machine", "Take 20 minutes to use the rowing machine today.", false, false, false, false, false, false, false, false, routineLinks);

        routineLinks.Clear();
        _InsertExercise(routineLinks, exercise_stationary_bicycle, "20 minutes", "");
        BuildRoutine(DB, "Use Stationary Bicycle", "Take 20 minutes to cycle today.", false, false, false, false, false, false, false, false, routineLinks);


        // Saturday, Wedneday: Rest Days - TODO: put in stretches options and such
        routineLinks.Clear();
        _InsertExercise(routineLinks, exercise_brisk_walk_on_treadmill, "20 minutes", "Or take a 20 minute brisk walk.");
        BuildRoutine(DB, "Brisk Walk on Treadmill", "Take 20 minutes to brisk walk on a treadmill today.", false, false, false, true, false, false, true, false, routineLinks);


        // Sunday: Medium effort - Arms/Shoulders
        routineLinks.Clear();
        _InsertExercise(routineLinks, exercise_brisk_walk_on_treadmill, "5-10 minutes", "Or warm up with something like jumping jacks.");
        _InsertExercise(routineLinks, exercise_floor_push_up, "20 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_standing_pull_up, "10 reps", "You can even use a tree.");
        _InsertExercise(routineLinks, exercise_floor_push_up, "20 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_standing_pull_up, "10 reps", "You can even use a tree.");
        _InsertExercise(routineLinks, exercise_plank, "60 seconds", "", RoutineRestAfter.No);
        BuildRoutine(DB, "Medium: Arms, Shoulders", "Small bodyweight exercises.", false, false, false, false, false, false, false, true, routineLinks);

        routineLinks.Clear();
        _InsertExercise(routineLinks, exercise_brisk_walk_on_treadmill, "5-10 minutes", "Or warm up with something like jumping jacks.");
        _InsertExercise(routineLinks, exercise_floor_push_up, "20 reps", "");
        _InsertExercise(routineLinks, exercise_standing_bicep_curls_with_dumbbells, "12 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_lateral_raises_with_dumbbells, "12 reps", "");
        _InsertExercise(routineLinks, exercise_floor_push_up, "20 reps", "");
        _InsertExercise(routineLinks, exercise_standing_bicep_curls_with_dumbbells, "12 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_lateral_raises_with_dumbbells, "12 reps", "");
        _InsertExercise(routineLinks, exercise_plank, "60 seconds", "", RoutineRestAfter.No);
        BuildRoutine(DB, "Medium: Arms, Shoulders", "Less bodyweight, using Dumbbells to do a little more.", false, false, false, false, false, false, false, true, routineLinks);

        routineLinks.Clear();
        _InsertExercise(routineLinks, exercise_brisk_walk_on_treadmill, "5-10 minutes", "Or warm up with something like jumping jacks.");
        _InsertExercise(routineLinks, exercise_floor_push_up, "20 reps", "");
        _InsertExercise(routineLinks, exercise_incline_barbell_bench_press, "10 reps", "Can be dumbbells.");
        _InsertExercise(routineLinks, exercise_incline_barbell_bench_press, "10 reps", "Can be dumbbells.");
        _InsertExercise(routineLinks, exercise_incline_barbell_bench_press, "10 reps", "Can be dumbbells.");
        _InsertExercise(routineLinks, exercise_floor_push_up, "20 reps", "");
        _InsertExercise(routineLinks, exercise_front_lateral_raises_with_dumbbells, "12 reps", "6 each side.");
        _InsertExercise(routineLinks, exercise_front_lateral_raises_with_dumbbells, "12 reps", "6 each side.");
        _InsertExercise(routineLinks, exercise_front_lateral_raises_with_dumbbells, "12 reps", "6 each side.");
        _InsertExercise(routineLinks, exercise_floor_push_up, "20 reps", "");
        _InsertExercise(routineLinks, exercise_standing_barbell_overhead_press, "12 reps", "Can be dumbbells.");
        _InsertExercise(routineLinks, exercise_standing_barbell_overhead_press, "12 reps", "Can be dumbbells.");
        _InsertExercise(routineLinks, exercise_standing_barbell_overhead_press, "12 reps", "Can be dumbbells.");
        _InsertExercise(routineLinks, exercise_plank, "60 seconds", "", RoutineRestAfter.No);
        BuildRoutine(DB, "Heavy: Arms, Shoudlers", "Mostly weighted exercise, focus on upper arms and shoulders.", false, false, false, false, false, false, false, true, routineLinks);

        routineLinks.Clear();
        _InsertExercise(routineLinks, exercise_brisk_walk_on_treadmill, "5-10 minutes", "Or warm up with something like jumping jacks.");
        _InsertExercise(routineLinks, exercise_seated_barbell_shoulder_press, "12 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_lateral_raises_with_dumbbells, "12 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_reverse_lateral_raise_with_dumbbells, "12 reps", "Rest for 60 seconds after");
        _InsertExercise(routineLinks, exercise_seated_barbell_shoulder_press, "12 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_lateral_raises_with_dumbbells, "12 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_reverse_lateral_raise_with_dumbbells, "12 reps", "Rest for 60 seconds after");
        _InsertExercise(routineLinks, exercise_seated_barbell_shoulder_press, "12 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_lateral_raises_with_dumbbells, "12 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_reverse_lateral_raise_with_dumbbells, "12 reps", "Rest for 60 seconds after");
        _InsertExercise(routineLinks, exercise_seated_bicep_curls_with_dumbbells, "12 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_standing_bicep_curls_with_dumbbells, "12 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_tricep_extension_with_dumbbells, "12 reps", "");
        _InsertExercise(routineLinks, exercise_seated_bicep_curls_with_dumbbells, "12 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_standing_bicep_curls_with_dumbbells, "12 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_tricep_extension_with_dumbbells, "12 reps", "");
        _InsertExercise(routineLinks, exercise_seated_bicep_curls_with_dumbbells, "12 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_standing_bicep_curls_with_dumbbells, "12 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_tricep_extension_with_dumbbells, "12 reps", "", RoutineRestAfter.No);
        BuildRoutine(DB, "Heavy: Full Dumbbell Arms & Shoulders", "Maintain your gains with this simple arms and shoulders exercise set", false, false, false, false, false, false, false, true, routineLinks);


        // Monday: Medium effort - Abs all round
        routineLinks.Clear();
        _InsertExercise(routineLinks, exercise_brisk_walk_on_treadmill, "5-10 minutes", "Or warm up with something like jumping jacks.");
        _InsertExercise(routineLinks, exercise_side_plank_with_dumbbells, "60 seconds", "Bodyweight is fine as well.");
        _InsertExercise(routineLinks, exercise_side_plank_with_dumbbells, "60 seconds", "Bodyweight is fine as well.");
        _InsertExercise(routineLinks, exercise_side_plank_with_dumbbells, "60 seconds", "Bodyweight is fine as well.");
        _InsertExercise(routineLinks, exercise_bear_crawl, "60 seconds", "");
        _InsertExercise(routineLinks, exercise_floor_bicycle_crunch, "12 reps", "");
        _InsertExercise(routineLinks, exercise_floor_bicycle_crunch, "12 reps", "");
        _InsertExercise(routineLinks, exercise_floor_bicycle_crunch, "12 reps", "");
        _InsertExercise(routineLinks, exercise_bear_crawl, "60 seconds", "");
        _InsertExercise(routineLinks, exercise_russian_twist_with_dumbbells, "12 reps each side", "Bodyweight is fine as well.");
        _InsertExercise(routineLinks, exercise_russian_twist_with_dumbbells, "12 reps each side", "Bodyweight is fine as well.");
        _InsertExercise(routineLinks, exercise_russian_twist_with_dumbbells, "12 reps each side", "Bodyweight is fine as well.");
        _InsertExercise(routineLinks, exercise_bear_crawl, "60 seconds", "", RoutineRestAfter.No);
        BuildRoutine(DB, "Medium: Abs, Core", "Core exercises are only as good as you make them.", false, true, false, false, false, false, false, false, routineLinks);

        routineLinks.Clear();
        _InsertExercise(routineLinks, exercise_brisk_walk_on_treadmill, "5-10 minutes", "Or warm up with something like jumping jacks.");
        _InsertExercise(routineLinks, exercise_plank, "60 seconds", "");
        _InsertExercise(routineLinks, exercise_floor_side_plank, "60 seconds", "");
        _InsertExercise(routineLinks, exercise_russian_twist_with_dumbbells, "20 reps", "Bodyweight is fine as well.");
        _InsertExercise(routineLinks, exercise_floor_bicycle_crunch, "20 reps", "");
        _InsertExercise(routineLinks, exercise_plank, "60 seconds", "");
        _InsertExercise(routineLinks, exercise_floor_side_plank, "60 seconds", "");
        _InsertExercise(routineLinks, exercise_russian_twist_with_dumbbells, "20 reps", "Bodyweight is fine as well.");
        _InsertExercise(routineLinks, exercise_floor_bicycle_crunch, "20 reps", "", RoutineRestAfter.No);
        BuildRoutine(DB, "Medium: Abs, Core", "Simple routine for anywhere.", false, true, false, false, false, false, false, false, routineLinks);

        routineLinks.Clear();
        _InsertExercise(routineLinks, exercise_brisk_walk_on_treadmill, "5-10 minutes", "Or warm up with something like jumping jacks.");
        _InsertExercise(routineLinks, exercise_dumbbell_swing, "15 reps", "Hold any object which has a little weight.", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_dumbbell_side_bend, "12 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_wood_chopper_chipper_with_dumbbells, "12 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_floor_crunch, "15 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_russian_twist_with_dumbbells, "15 reps", "");
        _InsertExercise(routineLinks, exercise_dumbbell_swing, "15 reps", "Hold any object which has a little weight.", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_dumbbell_side_bend, "12 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_wood_chopper_chipper_with_dumbbells, "12 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_floor_crunch, "15 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_russian_twist_with_dumbbells, "15 reps", "");
        _InsertExercise(routineLinks, exercise_dumbbell_swing, "15 reps", "Hold any object which has a little weight.", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_dumbbell_side_bend, "12 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_wood_chopper_chipper_with_dumbbells, "12 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_floor_crunch, "15 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_russian_twist_with_dumbbells, "15 reps", "", RoutineRestAfter.No);
        BuildRoutine(DB, "Heavy: Abs, Core", "Focus to give your whole core a workout.", false, true, false, false, false, false, false, false, routineLinks);

        routineLinks.Clear();
        _InsertExercise(routineLinks, exercise_brisk_walk_on_treadmill, "5-10 minutes", "Or warm up with something like jumping jacks.");
        _InsertExercise(routineLinks, exercise_alternating_shoulder_press_with_dumbbells, "16 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_lunge_single_arm_row_with_dumbbell, "12 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_dumbbell_deadlift_to_bicep_curl, "12 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_dumbbell_curtsy_lunge_to_upright_row, "12 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_dumbbell_bridge_with_curls, "12 reps", "");
        _InsertExercise(routineLinks, exercise_alternating_shoulder_press_with_dumbbells, "16 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_lunge_single_arm_row_with_dumbbell, "12 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_dumbbell_deadlift_to_bicep_curl, "12 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_dumbbell_curtsy_lunge_to_upright_row, "12 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_dumbbell_bridge_with_curls, "12 reps", "");
        _InsertExercise(routineLinks, exercise_alternating_shoulder_press_with_dumbbells, "16 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_lunge_single_arm_row_with_dumbbell, "12 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_dumbbell_deadlift_to_bicep_curl, "12 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_dumbbell_curtsy_lunge_to_upright_row, "12 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_dumbbell_bridge_with_curls, "12 reps", "", RoutineRestAfter.No);
        BuildRoutine(DB, "Heavy: Full Dumbbells Abs & Core", "Fire up multiple muscle groups at once with the focus on the core.", false, true, false, false, false, false, false, false, routineLinks);


        // Tueday: High effort - Back and Chest
        routineLinks.Clear();
        _InsertExercise(routineLinks, exercise_brisk_walk_on_treadmill, "5-10 minutes", "Or warm up with something like jumping jacks.");
        _InsertExercise(routineLinks, exercise_tricep_dips, "12 reps", "");
        _InsertExercise(routineLinks, exercise_tricep_dips, "12 reps", "");
        _InsertExercise(routineLinks, exercise_tricep_dips, "12 reps", "");
        _InsertExercise(routineLinks, exercise_tricep_dips, "12 reps", "");
        _InsertExercise(routineLinks, exercise_floor_push_up, "12 reps", "");
        _InsertExercise(routineLinks, exercise_floor_push_up, "12 reps", "");
        _InsertExercise(routineLinks, exercise_floor_push_up, "12 reps", "");
        _InsertExercise(routineLinks, exercise_floor_push_up, "12 reps", "");
        _InsertExercise(routineLinks, exercise_standing_pull_up, "12 reps", "You can even use a tree");
        _InsertExercise(routineLinks, exercise_standing_pull_up, "12 reps", "");
        _InsertExercise(routineLinks, exercise_standing_pull_up, "12 reps", "");
        _InsertExercise(routineLinks, exercise_standing_pull_up, "12 reps", "");
        _InsertExercise(routineLinks, exercise_plank, "60 seconds", "", RoutineRestAfter.No);
        BuildRoutine(DB, "Medium: Back, Chest", "Where there's a will, there's a way, try stick to the schedule.", false, false, true, false, false, false, false, false, routineLinks);

        routineLinks.Clear();
        _InsertExercise(routineLinks, exercise_brisk_walk_on_treadmill, "5-10 minutes", "Or warm up with something like jumping jacks.");
        _InsertExercise(routineLinks, exercise_floor_press_with_dumbbells, "16 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_flat_barbell_pullover, "12 reps", "");
        _InsertExercise(routineLinks, exercise_floor_press_with_dumbbells, "16 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_flat_barbell_pullover, "12 reps", "");
        _InsertExercise(routineLinks, exercise_floor_press_with_dumbbells, "16 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_flat_barbell_pullover, "12 reps", "");
        _InsertExercise(routineLinks, exercise_bent_over_fly_with_dumbbells, "16 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_floor_v_push_up, "12 reps", "");
        _InsertExercise(routineLinks, exercise_bent_over_fly_with_dumbbells, "16 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_floor_v_push_up, "12 reps", "");
        _InsertExercise(routineLinks, exercise_bent_over_fly_with_dumbbells, "16 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_floor_v_push_up, "12 reps", "");
        _InsertExercise(routineLinks, exercise_bent_over_row_with_dumbbells, "12 reps", "");
        _InsertExercise(routineLinks, exercise_bent_over_row_with_dumbbells, "12 reps", "");
        _InsertExercise(routineLinks, exercise_bent_over_row_with_dumbbells, "12 reps", "");
        _InsertExercise(routineLinks, exercise_bent_over_fly_with_dumbbells, "12 reps", "");
        _InsertExercise(routineLinks, exercise_bent_over_fly_with_dumbbells, "12 reps", "");
        _InsertExercise(routineLinks, exercise_bent_over_fly_with_dumbbells, "12 reps", "");
        _InsertExercise(routineLinks, exercise_tricep_extension_with_dumbbells, "12 reps", "");
        _InsertExercise(routineLinks, exercise_tricep_extension_with_dumbbells, "12 reps", "");
        _InsertExercise(routineLinks, exercise_tricep_extension_with_dumbbells, "12 reps", "");
        _InsertExercise(routineLinks, exercise_seated_barbell_shoulder_press, "16 reps", "");
        BuildRoutine(DB, "Heavy: Back, Chest", "Ready to work on upper body strength?", false, false, true, false, false, false, false, false, routineLinks);


        // Thursday: Medium effort - Abs and Arms?
        routineLinks.Clear();
        _InsertExercise(routineLinks, exercise_brisk_walk_on_treadmill, "5-10 minutes", "Or warm up with something like jumping jacks.");
        _InsertExercise(routineLinks, exercise_floor_push_up, "12 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_flat_barbell_bench_press, "12 reps", "");
        _InsertExercise(routineLinks, exercise_floor_push_up, "12 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_flat_barbell_bench_press, "12 reps", "");
        _InsertExercise(routineLinks, exercise_floor_push_up, "12 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_flat_barbell_bench_press, "12 reps", "");
        _InsertExercise(routineLinks, exercise_wood_chopper_chipper_with_dumbbells, "12 reps", "");
        _InsertExercise(routineLinks, exercise_wood_chopper_chipper_with_dumbbells, "12 reps", "");
        _InsertExercise(routineLinks, exercise_floor_bicycle_crunch, "16 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_plank, "60 seconds", "");
        _InsertExercise(routineLinks, exercise_floor_bicycle_crunch, "16 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_plank, "60 seconds", "", RoutineRestAfter.No);
        BuildRoutine(DB, "Medium: Abs, Arms", "A little burn in the right places", false, false, false, false, true, false, false, false, routineLinks);

        routineLinks.Clear();
        _InsertExercise(routineLinks, exercise_brisk_walk_on_treadmill, "5-10 minutes", "Or warm up with something like jumping jacks.");
        _InsertExercise(routineLinks, exercise_rorating_dumbbell_squat_press, "16 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_tricep_dips, "16 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_plank, "60 seconds", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_floor_v_push_up, "12 reps", "");
        _InsertExercise(routineLinks, exercise_rorating_dumbbell_squat_press, "16 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_tricep_dips, "16 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_plank, "60 seconds", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_floor_v_push_up, "12 reps", "");
        _InsertExercise(routineLinks, exercise_floor_mountain_climbers, "16 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_russian_twist_with_dumbbells, "16 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_floor_side_plank, "60 seconds", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_floor_v_push_up, "12 reps", "");
        _InsertExercise(routineLinks, exercise_floor_mountain_climbers, "16 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_russian_twist_with_dumbbells, "16 reps", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_floor_side_plank, "60 seconds", "", RoutineRestAfter.No);
        _InsertExercise(routineLinks, exercise_floor_v_push_up, "12 reps", "", RoutineRestAfter.No);
        BuildRoutine(DB, "Heavy: Abs, Arms", "Hmm, might need more, probably abs side.", false, false, false, false, true, false, false, false, routineLinks);


        // Friday: High effort - Legs
        routineLinks.Clear();
        _InsertExercise(routineLinks, exercise_brisk_walk_on_treadmill, "5-10 minutes", "Or warm up with something like jumping jacks.");
        _InsertExercise(routineLinks, exercise_standing_forward_lunges, "18 reps", "");
        _InsertExercise(routineLinks, exercise_standing_forward_lunges, "18 reps", "");
        _InsertExercise(routineLinks, exercise_standing_forward_lunges, "18 reps", "");
        _InsertExercise(routineLinks, exercise_standing_lateral_squat, "16 reps", "");
        _InsertExercise(routineLinks, exercise_standing_lateral_squat, "16 reps", "");
        _InsertExercise(routineLinks, exercise_standing_lateral_squat, "16 reps", "");
        _InsertExercise(routineLinks, exercise_floor_glute_bridge, "14 reps", "");
        _InsertExercise(routineLinks, exercise_floor_glute_bridge, "14 reps", "");
        _InsertExercise(routineLinks, exercise_floor_glute_bridge, "14 reps", "", RoutineRestAfter.No);
        BuildRoutine(DB, "Medium: Legs", "A good way to get the legs going.", false, false, false, false, false, true, false, false, routineLinks);

        routineLinks.Clear();
        _InsertExercise(routineLinks, exercise_brisk_walk_on_treadmill, "5-10 minutes", "Or warm up with something like jumping jacks.");
        _InsertExercise(routineLinks, exercise_dumbbell_deadlift_to_bicep_curl, "12 reps", "");
        _InsertExercise(routineLinks, exercise_dumbbell_deadlift_to_bicep_curl, "12 reps", "");
        _InsertExercise(routineLinks, exercise_dumbbell_deadlift_to_bicep_curl, "12 reps", "");
        _InsertExercise(routineLinks, exercise_reverse_lunge_with_dumbbells, "12 reps", "");
        _InsertExercise(routineLinks, exercise_reverse_lunge_with_dumbbells, "12 reps", "");
        _InsertExercise(routineLinks, exercise_reverse_lunge_with_dumbbells, "12 reps", "");
        _InsertExercise(routineLinks, exercise_weighted_squat_with_dumbbells, "12 reps", "");
        _InsertExercise(routineLinks, exercise_weighted_squat_with_dumbbells, "12 reps", "");
        _InsertExercise(routineLinks, exercise_weighted_squat_with_dumbbells, "12 reps", "");
        _InsertExercise(routineLinks, exercise_standing_barbell_calf_raises, "12 reps", "");
        _InsertExercise(routineLinks, exercise_standing_barbell_calf_raises, "12 reps", "");
        _InsertExercise(routineLinks, exercise_standing_barbell_calf_raises, "12 reps", "");
        _InsertExercise(routineLinks, exercise_sumo_squat_with_dumbbells, "12 reps", "");
        _InsertExercise(routineLinks, exercise_sumo_squat_with_dumbbells, "12 reps", "");
        _InsertExercise(routineLinks, exercise_sumo_squat_with_dumbbells, "12 reps", "");
        _InsertExercise(routineLinks, exercise_floor_glute_bridge, "12 reps", "");
        _InsertExercise(routineLinks, exercise_floor_glute_bridge, "12 reps", "");
        _InsertExercise(routineLinks, exercise_floor_glute_bridge, "12 reps", "");
        _InsertExercise(routineLinks, exercise_plank, "60 seconds", "", RoutineRestAfter.No);
        BuildRoutine(DB, "Heavy: Legs", "Strengthen the lower body.", false, false, false, false, false, true, false, false, routineLinks);

        routineLinks.Clear();
    }

    private static void _InsertExercise(List<MRoutineLink> routineLinks, MExercise exercise, string amount, string special)
    {
        routineLinks.Add(new MRoutineLink()
        {
            Amount = amount,
            ExerciseId = exercise.Id,
            Special = special,
            RestAfter = RoutineRestAfter.Yes
            // OrderNumber  automated
            // RoutineId automated
        });
    }

    private static void _InsertExercise(List<MRoutineLink> routineLinks, MExercise exercise, string amount, string special, RoutineRestAfter afterRest)
    {
        routineLinks.Add(new MRoutineLink()
        {
            Amount = amount,
            ExerciseId = exercise.Id,
            Special = special,
            RestAfter = afterRest
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
