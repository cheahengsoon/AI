﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace ToDoSkill
{
    using System.Collections.Generic;
    using global::ToDoSkill.Models;
    using Microsoft.Bot.Builder;
    using Microsoft.Bot.Builder.Dialogs;

    /// <summary>
    /// To Do state class.
    /// </summary>
    public class ToDoSkillState : DialogState
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToDoSkillState"/> class.
        /// </summary>
        public ToDoSkillState()
        {
            this.ToDoTaskContent = null;
            this.ToDoTaskActivity = new ToDoTaskActivityModel();
            this.ToDoTaskActivities = new List<ToDoTaskActivityModel>();
            this.ToDoTaskIndex = -1;
            this.MsGraphToken = null;
            this.ShowToDoPageIndex = 0;
            this.ToDoTaskAllActivities = new List<ToDoTaskActivityModel>();
            this.DeleteTaskConfirmation = false;
            this.MarkOrDeleteAllTasksFlag = false;
            this.OneNotePageId = null;
            this.LuisResult = null;
            this.LuisResultPassedFromSkill = null;
            this.ConversationDialogState = null;
        }

        /// <summary>
        /// Gets PageSize.
        /// </summary>
        /// <value>
        /// PageSize.
        /// </value>
        public int PageSize { get; } = 5;

        /// <summary>
        /// Gets Luis intent score threshold.
        /// </summary>
        /// <value>
        /// Luis intent score threshold.
        /// </value>
        public double ScoreThreshold { get; } = 0.7;

        /// <summary>
        /// Gets or sets ToDoTaskContent.
        /// </summary>
        /// <value>
        /// ToDoTaskContent.
        /// </value>
        public string ToDoTaskContent { get; set; }

        /// <summary>
        /// Gets or sets ToDoTaskActivity.
        /// </summary>
        /// <value>
        /// ToDoTaskActivity.
        /// </value>
        public ToDoTaskActivityModel ToDoTaskActivity { get; set; }

        /// <summary>
        /// Gets or sets ToDoTaskActivities.
        /// </summary>
        /// <value>
        /// ToDoTaskActivities.
        /// </value>
        public List<ToDoTaskActivityModel> ToDoTaskActivities { get; set; }

        /// <summary>
        /// Gets or sets ToDoTaskIndex.
        /// </summary>
        /// <value>
        /// ToDoTaskIndex.
        /// </value>
        public int ToDoTaskIndex { get; set; }

        /// <summary>
        /// Gets or sets MsGraphToken.
        /// </summary>
        /// <value>
        /// MsGraphToken.
        /// </value>
        public string MsGraphToken { get; set; }

        /// <summary>
        /// Gets or sets ShowToDoPageIndex.
        /// </summary>
        /// <value>
        /// ShowToDoPageIndex.
        /// </value>
        public int ShowToDoPageIndex { get; set; }

        /// <summary>
        /// Gets or sets ToDoTaskAllActivities.
        /// </summary>
        /// <value>
        /// ToDoTaskAllActivities.
        /// </value>
        public List<ToDoTaskActivityModel> ToDoTaskAllActivities { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether DeleteTaskConfirmation.
        /// </summary>
        /// <value>
        /// A value indicating whether DeleteTaskConfirmation.
        /// </value>
        public bool DeleteTaskConfirmation { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether MarkOrDeleteAllTasksFlag.
        /// </summary>
        /// <value>
        /// A value indicating whether MarkOrDeleteAllTasksFlag.
        /// </value>
        public bool MarkOrDeleteAllTasksFlag { get; set; }

        /// <summary>
        /// Gets or sets OneNotePageId.
        /// </summary>
        /// <value>
        /// OneNotePageId.
        /// </value>
        public string OneNotePageId { get; set; }

        /// <summary>
        /// Gets or sets LuisResult.
        /// </summary>
        /// <value>
        /// LuisResult.
        /// </value>
        public IRecognizerConvert LuisResult { get; set; }

        /// <summary>
        /// Gets or sets LuisResultPassedFromSkill.
        /// </summary>
        /// <value>
        /// LuisResultPassedFromSkill.
        /// </value>
        public IRecognizerConvert LuisResultPassedFromSkill { get; set; }

        /// <summary>
        /// Gets or sets ConversationDialogState.
        /// </summary>
        /// <value>
        /// ConversationDialogState.
        /// </value>
        public DialogState ConversationDialogState { get; set; }

        /// <summary>
        /// Clear state.
        /// </summary>
        public void Clear()
        {
            this.ToDoTaskContent = null;
            this.ToDoTaskActivity = new ToDoTaskActivityModel();
            this.ToDoTaskActivities = new List<ToDoTaskActivityModel>();
            this.ToDoTaskIndex = -1;
            this.MsGraphToken = null;
            this.ShowToDoPageIndex = 0;
            this.ToDoTaskAllActivities = new List<ToDoTaskActivityModel>();
            this.DeleteTaskConfirmation = false;
            this.MarkOrDeleteAllTasksFlag = false;
            this.OneNotePageId = null;
            this.LuisResult = null;
            this.LuisResultPassedFromSkill = null;
            this.ConversationDialogState = null;
        }
    }
}
