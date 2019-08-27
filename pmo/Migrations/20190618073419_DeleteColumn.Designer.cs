﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using pmo.Models;

namespace pmo.Migrations
{
    [DbContext(typeof(pmo_dbContext))]
    [Migration("20190618073419_DeleteColumn")]
    partial class DeleteColumn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("pmo.Models.Assign", b =>
                {
                    b.Property<int>("AssignId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ASSIGN_ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AssignCreatedDate")
                        .HasColumnName("ASSIGN_CREATED_DATE")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("AssignModifiedDate")
                        .HasColumnName("ASSIGN_MODIFIED_DATE")
                        .HasColumnType("datetime");

                    b.Property<int?>("ProjectId")
                        .HasColumnName("PROJECT_ID");

                    b.Property<int?>("RoleId")
                        .HasColumnName("ROLE_ID");

                    b.Property<int?>("UserId")
                        .HasColumnName("USER_ID");

                    b.HasKey("AssignId");

                    b.HasIndex("ProjectId")
                        .HasName("RELATIONSHIP_1_FK");

                    b.HasIndex("RoleId")
                        .HasName("RELATIONSHIP_2_FK");

                    b.HasIndex("UserId")
                        .HasName("RELATIONSHIP_3_FK");

                    b.ToTable("ASSIGN");
                });

            modelBuilder.Entity("pmo.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CATEGORY_ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CategoryCreatedDate")
                        .HasColumnName("CATEGORY_CREATED_DATE")
                        .HasColumnType("datetime");

                    b.Property<string>("CategoryDescription")
                        .HasColumnName("CATEGORY_DESCRIPTION")
                        .HasColumnType("text");

                    b.Property<DateTime>("CategoryModifiedDate")
                        .HasColumnName("CATEGORY_MODIFIED_DATE")
                        .HasColumnType("datetime");

                    b.Property<string>("CategoryName")
                        .HasColumnName("CATEGORY_NAME")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<byte[]>("FileStream")
                        .HasColumnName("FILE_STREAM");

                    b.HasKey("CategoryId");

                    b.ToTable("CATEGORY");
                });

            modelBuilder.Entity("pmo.Models.Document", b =>
                {
                    b.Property<int>("DocId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("DOC_ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnName("CATEGORY_ID");

                    b.Property<DateTime>("DocCreatedDate")
                        .HasColumnName("DOC_CREATED_DATE")
                        .HasColumnType("datetime");

                    b.Property<string>("DocDescription")
                        .HasColumnName("DOC_DESCRIPTION")
                        .HasColumnType("text");

                    b.Property<DateTime>("DocModifiedDate")
                        .HasColumnName("DOC_MODIFIED_DATE")
                        .HasColumnType("datetime");

                    b.Property<string>("DocName")
                        .HasColumnName("DOC_NAME")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<long?>("DocSize")
                        .HasColumnName("DOC_SIZE");

                    b.Property<int?>("DocStatus")
                        .HasColumnName("DOC_STATUS");

                    b.Property<byte[]>("DocStream")
                        .HasColumnName("DOC_STREAM");

                    b.Property<string>("DocType")
                        .HasColumnName("DOC_TYPE")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<int?>("LessonLearnedId")
                        .HasColumnName("LESSON_LEARNED_ID");

                    b.Property<int?>("ProjectId")
                        .HasColumnName("PROJECT_ID");

                    b.HasKey("DocId");

                    b.HasIndex("CategoryId")
                        .HasName("RELATIONSHIP_15_FK");

                    b.HasIndex("LessonLearnedId")
                        .HasName("RELATIONSHIP_20_FK");

                    b.HasIndex("ProjectId")
                        .HasName("RELATIONSHIP_14_FK");

                    b.ToTable("DOCUMENT");
                });

            modelBuilder.Entity("pmo.Models.History", b =>
                {
                    b.Property<int>("HistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("HISTORY_ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnName("COMMENT")
                        .HasColumnType("text");

                    b.Property<DateTime>("HistoryModifiedDate")
                        .HasColumnName("HISTORY_MODIFIED_DATE")
                        .HasColumnType("datetime");

                    b.Property<int?>("ProjectId")
                        .HasColumnName("PROJECT_ID");

                    b.Property<int>("StatusAfter")
                        .HasColumnName("STATUS_AFTER");

                    b.Property<int>("StatusBefore")
                        .HasColumnName("STATUS_BEFORE");

                    b.Property<int?>("UserId")
                        .HasColumnName("USER_ID");

                    b.HasKey("HistoryId");

                    b.HasIndex("ProjectId")
                        .HasName("RELATIONSHIP_17_FK");

                    b.HasIndex("UserId")
                        .HasName("RELATIONSHIP_18_FK");

                    b.ToTable("HISTORY");
                });

            modelBuilder.Entity("pmo.Models.LessonLearned", b =>
                {
                    b.Property<int>("LessonLearnedId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("LESSON_LEARNED_ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Impact")
                        .HasColumnName("IMPACT")
                        .HasColumnType("text");

                    b.Property<int?>("LLCategoryId")
                        .HasColumnName("LL_CATEGORY_ID");

                    b.Property<DateTime>("LessonLearnedCreatedDate")
                        .HasColumnName("LL_CREATED_DATE")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("LessonLearnedModifiedDate")
                        .HasColumnName("LL_MODIFIED_DATE")
                        .HasColumnType("datetime");

                    b.Property<string>("LessonLearnedText")
                        .HasColumnName("LESSON_LEARNED_TEXT")
                        .HasColumnType("text");

                    b.Property<int?>("ProjectCategoryId")
                        .HasColumnName("PROJECT_CATEGORY_ID");

                    b.Property<int?>("ProjectId")
                        .HasColumnName("PROJECT_ID");

                    b.Property<string>("Recommendation")
                        .HasColumnName("RECOMMENDATION")
                        .HasColumnType("text");

                    b.Property<int?>("UserId")
                        .HasColumnName("USER_ID");

                    b.HasKey("LessonLearnedId");

                    b.HasIndex("LLCategoryId")
                        .HasName("RELATIONSHIP_21_FK");

                    b.HasIndex("ProjectCategoryId")
                        .HasName("RELATIONSHIP_23_FK");

                    b.HasIndex("ProjectId")
                        .HasName("RELATIONSHIP_16_FK");

                    b.HasIndex("UserId")
                        .HasName("RELATIONSHIP_22_FK");

                    b.ToTable("LESSON_LEARNED");
                });

            modelBuilder.Entity("pmo.Models.LessonLearnedCategory", b =>
                {
                    b.Property<int>("LLCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("LLCATEGORY_ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("LLCategoryCreatedDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("LLCategoryModifiedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("LLCategoryName")
                        .HasColumnName("LLCATEGORY_NAME")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("LLCategoryId");

                    b.ToTable("LESSON_LEARNED_CATEGORY");
                });

            modelBuilder.Entity("pmo.Models.Milestone", b =>
                {
                    b.Property<int>("MilestoneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("MILESTONE_ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("EstimatedEndTime")
                        .HasColumnName("ESTIMATED_END_TIME")
                        .HasColumnType("date");

                    b.Property<DateTime?>("EstimatedStartTime")
                        .HasColumnName("ESTIMATED_START_TIME")
                        .HasColumnType("date");

                    b.Property<DateTime>("MilestoneCreatedDate")
                        .HasColumnName("MILESTONE_CREATED_DATE")
                        .HasColumnType("datetime");

                    b.Property<string>("MilestoneDescription")
                        .HasColumnName("MILESTONE_DESCRIPTION")
                        .HasColumnType("text");

                    b.Property<DateTime>("MilestoneModifiedDate")
                        .HasColumnName("MILESTONE_MODIFIED_DATE")
                        .HasColumnType("datetime");

                    b.Property<int?>("ProjectId")
                        .HasColumnName("PROJECT_ID");

                    b.HasKey("MilestoneId");

                    b.HasIndex("ProjectId")
                        .HasName("RELATIONSHIP_19_FK");

                    b.ToTable("MILESTONE");
                });

            modelBuilder.Entity("pmo.Models.Permission", b =>
                {
                    b.Property<int>("PermissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PERMISSION_ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("PermissionCreatedDate")
                        .HasColumnName("PERMISSION_CREATED_DATE")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("PermissionModifiedDate")
                        .HasColumnName("PERMISSION_MODIFIED_DATE")
                        .HasColumnType("datetime");

                    b.Property<string>("PermissionName")
                        .HasColumnName("PERMISSION_NAME")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("PermissionId");

                    b.ToTable("PERMISSION");
                });

            modelBuilder.Entity("pmo.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PROJECT_ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AcknowledgedBy")
                        .HasColumnName("ACKNOWLEDGED_BY");

                    b.Property<int?>("AgreedBy")
                        .HasColumnName("AGREED_BY");

                    b.Property<string>("Assumption")
                        .HasColumnName("ASSUMPTION")
                        .HasColumnType("text");

                    b.Property<string>("BackgroundInformation")
                        .HasColumnName("BACKGROUND_INFORMATION")
                        .HasColumnType("text");

                    b.Property<int>("Building")
                        .HasColumnName("BUILDING");

                    b.Property<string>("ChangeControlManagement")
                        .HasColumnName("CHANGE_CONTROL_MANAGEMENT")
                        .HasColumnType("text");

                    b.Property<int>("Contingency")
                        .HasColumnName("CONTINGENCY");

                    b.Property<int>("Equipment")
                        .HasColumnName("EQUIPMENT");

                    b.Property<string>("ExecutiveSummary")
                        .HasColumnName("EXECUTIVE_SUMMARY")
                        .HasColumnType("text");

                    b.Property<string>("ExecutiveSummaryOfProjectInitiative")
                        .HasColumnName("EXECUTIVE_SUMMARY_OF_PROJECT_INITIATIVE")
                        .HasColumnType("text");

                    b.Property<int>("ExpenseUnderDevelopment")
                        .HasColumnName("EXPENSE_UNDER_DEVELOPMENT");

                    b.Property<int>("Infrastructure")
                        .HasColumnName("INFRASTRUCTURE");

                    b.Property<string>("InitiativeTitle")
                        .HasColumnName("INITIATIVE_TITLE")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<int>("LandCompensation")
                        .HasColumnName("LAND_COMPENSATION");

                    b.Property<int>("LandImprovement")
                        .HasColumnName("LAND_IMPROVEMENT");

                    b.Property<string>("Objective")
                        .HasColumnName("OBJECTIVE")
                        .HasColumnType("text");

                    b.Property<string>("ObjectiveBenefit")
                        .HasColumnName("OBJECTIVE_BENEFIT")
                        .HasColumnType("text");

                    b.Property<int>("PlantMachine")
                        .HasColumnName("PLANT_MACHINE");

                    b.Property<DateTime?>("PreparedDate")
                        .HasColumnName("PREPARED_DATE")
                        .HasColumnType("date");

                    b.Property<DateTime>("ProjectCreatedDate")
                        .HasColumnName("PROJECT_CREATED_DATE")
                        .HasColumnType("datetime");

                    b.Property<string>("ProjectDefinition")
                        .HasColumnName("PROJECT_DEFINITION")
                        .HasColumnType("text");

                    b.Property<string>("ProjectManagementPlan")
                        .HasColumnName("PROJECT_MANAGEMENT_PLAN")
                        .HasColumnType("text");

                    b.Property<DateTime>("ProjectModifiedDate")
                        .HasColumnName("PROJECT_MODIFIED_DATE")
                        .HasColumnType("datetime");

                    b.Property<int>("ProjectStatus")
                        .HasColumnName("PROJECT_STATUS");

                    b.Property<int?>("RequestedBy")
                        .HasColumnName("REQUESTED_BY");

                    b.Property<string>("ScheduleAndTimeDescription")
                        .HasColumnName("SCHEDULE_TIME_DESCRIPTION")
                        .HasColumnType("text");

                    b.Property<string>("Timeline")
                        .HasColumnName("TIMELINE")
                        .HasColumnType("text");

                    b.Property<int>("Total")
                        .HasColumnName("TOTAL");

                    b.Property<string>("Vision")
                        .HasColumnName("VISION")
                        .HasColumnType("text");

                    b.Property<int>("WorkingCapital")
                        .HasColumnName("WORKING_CAPITAL");

                    b.HasKey("ProjectId");

                    b.ToTable("PROJECT");
                });

            modelBuilder.Entity("pmo.Models.ProjectCategory", b =>
                {
                    b.Property<int>("ProjectCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PROJECT_CATEGORY_ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ProjectCategoryCreatedDate")
                        .HasColumnName("PROJECT_CATEGORY_CREATED_DATE")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("ProjectCategoryModifiedDate")
                        .HasColumnName("PROJECT_CATEGORY_MODIFIED_DATE")
                        .HasColumnType("datetime");

                    b.Property<string>("ProjectCategoryName")
                        .HasColumnName("PROJECT_CATEGORY_NAME")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("ProjectCategoryId");

                    b.ToTable("PROJECT_CATEGORY");
                });

            modelBuilder.Entity("pmo.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ROLE_ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("RoleCreatedDate")
                        .HasColumnName("ROLE_CREATED_DATE")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("RoleModifiedDate")
                        .HasColumnName("ROLE_MODIFIED_DATE")
                        .HasColumnType("datetime");

                    b.Property<string>("RoleName")
                        .HasColumnName("ROLE_NAME")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("RoleId");

                    b.ToTable("ROLE");
                });

            modelBuilder.Entity("pmo.Models.RoleHasPermission", b =>
                {
                    b.Property<int>("RhpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("RHP_ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RoleId")
                        .HasColumnName("ROLE_ID");

                    b.Property<int>("PermissionId")
                        .HasColumnName("PERMISSION_ID");

                    b.Property<DateTime>("RhpCreatedDate")
                        .HasColumnName("RHP_CREATED_DATE")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("RhpModifiedDate")
                        .HasColumnName("RHP_MODIFIED_DATE")
                        .HasColumnType("datetime");

                    b.HasKey("RhpId", "RoleId", "PermissionId");

                    b.HasIndex("PermissionId")
                        .HasName("RELATIONSHIP_5_FK");

                    b.HasIndex("RoleId")
                        .HasName("RELATIONSHIP_4_FK");

                    b.ToTable("ROLE_HAS_PERMISSION");
                });

            modelBuilder.Entity("pmo.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("USER_ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("UserCreatedDate")
                        .HasColumnName("USER_CREATED_DATE")
                        .HasColumnType("datetime");

                    b.Property<string>("UserEmail")
                        .HasColumnName("USER_EMAIL")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<DateTime>("UserModifiedDate")
                        .HasColumnName("USER_MODIFIED_DATE")
                        .HasColumnType("datetime");

                    b.Property<string>("UserName")
                        .HasColumnName("USER_NAME")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("UserPassword")
                        .HasColumnName("USER_PASSWORD")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<string>("UserStatus")
                        .HasColumnName("USER_STATUS")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.HasKey("UserId");

                    b.ToTable("USER");
                });

            modelBuilder.Entity("pmo.Models.Assign", b =>
                {
                    b.HasOne("pmo.Models.Project", "Project")
                        .WithMany("Assign")
                        .HasForeignKey("ProjectId")
                        .HasConstraintName("FK_ASSIGN_RELATIONS_PROJECT");

                    b.HasOne("pmo.Models.Role", "Role")
                        .WithMany("Assign")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_ASSIGN_RELATIONS_ROLE");

                    b.HasOne("pmo.Models.User", "User")
                        .WithMany("Assign")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_ASSIGN_RELATIONS_USER");
                });

            modelBuilder.Entity("pmo.Models.Document", b =>
                {
                    b.HasOne("pmo.Models.Category", "Category")
                        .WithMany("Document")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_DOCUMENT_RELATIONS_CATEGORY");

                    b.HasOne("pmo.Models.LessonLearned", "LessonLearned")
                        .WithMany("Document")
                        .HasForeignKey("LessonLearnedId")
                        .HasConstraintName("FK_DOCUMENT_RELATIONS_LESSON_LEARNED");

                    b.HasOne("pmo.Models.Project", "Project")
                        .WithMany("Document")
                        .HasForeignKey("ProjectId")
                        .HasConstraintName("FK_DOCUMENT_RELATIONS_PROJECT");
                });

            modelBuilder.Entity("pmo.Models.History", b =>
                {
                    b.HasOne("pmo.Models.Project", "Project")
                        .WithMany("History")
                        .HasForeignKey("ProjectId")
                        .HasConstraintName("FK_HISTORY_RELATIONS_PROJECT");

                    b.HasOne("pmo.Models.User", "User")
                        .WithMany("History")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_HISTORY_RELATIONS_USER");
                });

            modelBuilder.Entity("pmo.Models.LessonLearned", b =>
                {
                    b.HasOne("pmo.Models.LessonLearnedCategory", "LessonLearnedCategory")
                        .WithMany("LessonLearned")
                        .HasForeignKey("LLCategoryId")
                        .HasConstraintName("FK_LESSONLEARNED_RELATION_LLCATEGORY");

                    b.HasOne("pmo.Models.ProjectCategory", "ProjectCategory")
                        .WithMany("LessonLearned")
                        .HasForeignKey("ProjectCategoryId")
                        .HasConstraintName("FK_LESSONLEARNED_RELATION_PROJECTCATEGORY");

                    b.HasOne("pmo.Models.Project", "Project")
                        .WithMany("LessonLearned")
                        .HasForeignKey("ProjectId")
                        .HasConstraintName("FK_LESSONLEARNED_RELATIONS_PROJECT");

                    b.HasOne("pmo.Models.User", "User")
                        .WithMany("LessonLearned")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_LESSONLEARNED_RELATION_USER");
                });

            modelBuilder.Entity("pmo.Models.Milestone", b =>
                {
                    b.HasOne("pmo.Models.Project", "Project")
                        .WithMany("Milestone")
                        .HasForeignKey("ProjectId")
                        .HasConstraintName("FK_MILESTONE_RELATIONS_PROJECT");
                });

            modelBuilder.Entity("pmo.Models.RoleHasPermission", b =>
                {
                    b.HasOne("pmo.Models.Permission", "Permission")
                        .WithMany("RoleHasPermission")
                        .HasForeignKey("PermissionId")
                        .HasConstraintName("FK_ROLE_HAS_RELATIONS_PERMISSI");

                    b.HasOne("pmo.Models.Role", "Role")
                        .WithMany("RoleHasPermission")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_ROLE_HAS_RELATIONS_ROLE");
                });
#pragma warning restore 612, 618
        }
    }
}
