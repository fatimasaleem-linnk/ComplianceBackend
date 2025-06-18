using ComplianceAndPeformanceSystem.Contract.Enums;
using ComplianceAndPeformanceSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComplianceAndPeformanceSystem.DAL.Seeds;

public class ComplianceNotificationMassageSeed : IEntityTypeConfiguration<ComplianceNotificationMassage>
{
    public void Configure(EntityTypeBuilder<ComplianceNotificationMassage> builder)
    {
        builder.HasData(new List<ComplianceNotificationMassage>()
        {
            #region Phase 1
            new ComplianceNotificationMassage()
            {
                Id = 1,
                Role = "ComplianceManager",
                MessageType = "info",
                MessageTitleAR = "يمكنك الأن تعيين احد الأخصائين لإدارج الخطة السنوية",
                MessageTitleEn = "You can now appoint a specialist to include the annual plan.",
                MessageBodyAR = "يرجي التدخل لإدراج احد المتخصين لوضع الخطة من الرابط ادناه",
                MessageBodyEn = "Please intervene to include a specialist to develop the plan from the link below",
                ActionUrl = "/",
            },
            new ComplianceNotificationMassage()
            {
                Id = 2,
                Role = "ComplianceManager",
                MessageType = "error",
                MessageTitleAR = "يمكنك الأن تعيين احد الأخصائين لإدارج الخطة السنوية",
                MessageTitleEn = "You can now appoint a specialist to include the annual plan.",
                MessageBodyAR = "يرجي التدخل لإدراج احد المتخصين لوضع الخطة من الرابط ادناه",
                MessageBodyEn = "Please intervene to include a specialist to develop the plan from the link below",
                ActionUrl = "/",
            },
            new ComplianceNotificationMassage()
            {
                Id = 3,
                Role = "ComplianceManager",
                MessageType = "info",
                MessageTitleAR = "خطة الامتثال السنوية الجديدة المقدمة للمراجعة",
                MessageTitleEn = "New Annual Compliance Plan Submitted for Review",
                MessageBodyAR = " وهي جاهزة لمراجعتك واعتمادك حيث ان الوقت المخصص للمراجعة هو ٧ ايام",
                MessageBodyEn = "It is ready for your review and approval, as the review time is 7 days.",
                ActionUrl = "/",
            },
            new ComplianceNotificationMassage()
            {
                Id = 4,
                Role = "ComplianceManager",
                MessageType = "info",
                MessageTitleAR = "الوقت المتبقي للإنتهاء من مراجعتك للخطة الزمنية هو ٥ ايام",
                MessageTitleEn = "The time remaining to complete the review of the timeline is 5 days.",
                MessageBodyAR = " يرجي الانتهاء من مراجعة الخطة في الوقت المحدد حيث ان ذلك يسهل ويساعد علي اكتمال المراحل القادمة بشكل جيد",
                MessageBodyEn = "Please complete the plan review on time as this will facilitate and help complete the next stages well.",
                ActionUrl = "/",
            },
            new ComplianceNotificationMassage()
            {
                Id = 5,
                Role = "ComplianceManager",
                MessageType = "error",
                MessageTitleAR = "هذا تذكير نهائي بأن الموعد النهائي لتقديم خطة الامتثال السنوية لا يزال على بعد يومين فقط.",
                MessageTitleEn = "This is a final reminder that the deadline for submitting your annual compliance plan is just two days away.",
                MessageBodyAR = " يرجى التأكد من إكمال جميع الخطوات المطلوبة، وتقديم الخطة في الوقت المحدد يعد تقديمك في الوقت المناسب أمرًا بالغ الأهمية لتحقيق أهداف الامتثال\r\nإذا كنت بحاجة إلى مساعدة، يرجى الاتصال بمديرك على الفور للحصول على الخطة في الرابط ادناه",
                MessageBodyEn = "Please ensure you complete all required steps and submit the plan on time. Your timely submission is critical to achieving compliance goals. If you need assistance, please contact your manager immediately to obtain the plan at the link below.",
                ActionUrl = "/",
            },
            new ComplianceNotificationMassage()
            {
                Id = 6,
                Role = "ComplianceManager",
                MessageType = "error",
                MessageTitleAR = "نأسف لإبلاغك بأن مراجعة الخطة الامتثال السنوية لم يكتمل في الإطار الزمني المحدد لذا سيتم تصعيد الأمر للمدير العام .",
                MessageTitleEn = "We regret to inform you that the annual compliance plan review was not completed within the specified time frame and therefore the matter will be escalated to the General Manager.",
                MessageBodyAR = "يرجى التأكد من إكمال جميع الخطوات المطلوبة، وتقديم الخطة في الوقت المحدد يعد تقديمك في الوقت المناسب أمرًا بالغ الأهمية لتحقيق أهداف الامتثال\r\nإذا كنت بحاجة إلى مساعدة، يرجى الاتصال بمديرك على الفور للحصول على الخطة في الرابط ادناه",
                MessageBodyEn = "Please ensure you complete all required steps and submit the plan on time. Your timely submission is critical to achieving compliance goals. If you need assistance, please contact your manager immediately to obtain the plan at the link below.",
                ActionUrl = "/",
            },
            new ComplianceNotificationMassage()
            {
                Id = 7,
                Role = "ComplianceManager",
                MessageType = "info",
                MessageTitleAR = "الاخصائي  قد تلقى تعديلات من المدير العام لمراقبة الاداء",
                MessageTitleEn = "The specialist has received modifications from Performance Monitoring Manager.",
                MessageBodyAR = "يرجي العلم ان دور المدير هنا متلقي للاشعارات فقط ولا يمكنه الدخول للخطة لاجراء اي تعديلات عليها",
                MessageBodyEn = "Please note that the role of the manager here is to receive notifications only and cannot access the plan to make any changes to it.",
                ActionUrl = "/",
            },
            new ComplianceNotificationMassage()
            {
                Id = 8,
                Role = "ComplianceManager",
                MessageType = "info",
                MessageTitleAR = "الاخصائي  قد ارسل الخطة بعد التعديل الى المدير العام لمراقبة الاداء",
                MessageTitleEn = "The specialist sent the modified plan to Performance Monitoring Manager.",
                MessageBodyAR = "يرجي العلم ان دور المدير هنا متلقي للاشعارات فقط ولا يمكنه الدخول للخطة لاجراء اي تعديلات عليها",
                MessageBodyEn = "Please note that the role of the manager here is to receive notifications only and cannot access the plan to make any changes to it.",
                ActionUrl = "/",
            },

            new ComplianceNotificationMassage()
            {
                Id = 9,
                Role = "PerformanceMonitoringManager",
                MessageType = "info",
                MessageTitleAR = "انتهت فترة مراجعة خطة الامتثال السنوية بعنوان {{PlanTitle}} دون اتخاذ أي إجراء.",
                MessageTitleEn = "The annual compliance plan review period for {{PlanTitle}} has ended without any action.",
                MessageBodyAR = "يرجي  التدخل لضمان مراجعة الخطة يتطلب الأمر اهتمامًا فوريًا لحل هذه المهمة المتأخرة.",
                MessageBodyEn = "Please intervene to ensure the plan is reviewed. Immediate attention is required to resolve this delayed task.",
                ActionUrl = "/",
              
            },
            new ComplianceNotificationMassage()
            {
                Id = 10,
                Role = "PerformanceMonitoringManager",
                MessageType = "info",
                MessageTitleAR = "تم عمل خطة الامتثال السنوي من قبل الاخصائي وقبولها من قبل المدير المسؤول الخطة جاهزة لمراجعتك خلال ٧ ايام ",
                MessageTitleEn = "The annual compliance plan has been prepared by the specialist and accepted by the responsible manager. The plan is ready for your review within 7 days.",
                MessageBodyAR = "يرجي التدخل لضمان مراجعة الخطة يتطلب الأمر اهتمامًا لمراجة الخطة بشكل كامل واعتمادها او ارجعها الي الاخصايئ للعمل التعديلات",
                MessageBodyEn = "Please intervene to ensure the plan is reviewed. It requires attention to review the plan completely and approve it or return it to the specialist to make amendments.",
                ActionUrl = "/",
            },
            new ComplianceNotificationMassage()
            {
                Id = 11,
                Role = "PerformanceMonitoringManager",
                MessageType = "error",
                MessageTitleAR = "هذا تذكير نهائي بأن الموعد النهائي لتقديم خطة الامتثال السنوية لا يزال على بعد يومين فقط. ",
                MessageTitleEn = "This is a final reminder that the deadline for submitting your annual compliance plan is just two days away.",
                MessageBodyAR = "يرجى التأكد من إكمال جميع الخطوات المطلوبة، وتقديم الخطة في الوقت المحدد يعد تقديمك في الوقت المناسب أمرًا بالغ الأهمية لتحقيق أهداف الامتثال\r\nإذا كنت بحاجة إلى مساعدة، يرجى الاتصال بمديرك على الفور للحصول على الخطة في الرابط ادناه",
                MessageBodyEn = "Please ensure you complete all required steps and submit the plan on time. Your timely submission is critical to achieving compliance goals. If you need assistance, please contact your manager immediately to obtain the plan at the link below.",
                ActionUrl = "/",
            },
            new ComplianceNotificationMassage()
            {
                Id = 12,
                Role = "PerformanceMonitoringManager",
                MessageType = "info",
                MessageTitleAR = "نأسف لإبلاغك بأن مراجعة خطة الامتثال السنوية لم تكتمل في الإطار الزمني المحدد لذا فضلاً يرجي الانتهاء منها في اقرب وقت",
                MessageTitleEn = "We regret to inform you that the review of the annual compliance plan was not completed within the specified time frame, so please complete it as soon as possible.",
                MessageBodyAR = "يرجى التأكد من إكمال جميع الخطوات المطلوبة، وتقديم الخطة في الوقت المحدد يعد تقديمك في الوقت المناسب أمرًا بالغ الأهمية لتحقيق أهداف الامتثال\r\nإذا كنت بحاجة إلى مساعدة، يرجى الاتصال بمديرك على الفور للحصول على الخطة في الرابط ادناه",
                MessageBodyEn = "Please ensure you complete all required steps and submit the plan on time. Your timely submission is critical to achieving compliance goals. If you need assistance, please contact your manager immediately to obtain the plan at the link below.",
                ActionUrl = "/",
            },


            new ComplianceNotificationMassage()
            {
                Id = 13,
                Role = "ComplianceSpecialist",
                MessageType = "info",
                MessageTitleAR = "إبدأ الخطة",
                MessageTitleEn = "Start Plan",
                MessageBodyAR = "يتعين عليك جمع وتحليل البيانات ذات الصلة، واستكمال التقييمات اللازمة، والبدء في صياغة الخطة في النظام. ويجب إكمال عملية الإعداد في غضون 60 يوم عمل بدءًا من اليوم للوصول إلى نموذج إعداد خطة الامتثال، ",
                MessageBodyEn = "You must collect and analyze relevant data, complete the necessary assessments, and begin drafting the plan in the system. The preparation process must be completed within 20 business days from today to access the compliance plan preparation form.",
                ActionUrl = "/",
            },
            new ComplianceNotificationMassage()
            {
                Id = 14,
                Role = "ComplianceSpecialist",
                MessageType = "error",
                MessageTitleAR = "إبدأ الخطة",
                MessageTitleEn = "Start Plan",
                MessageBodyAR = "يتعين عليك جمع وتحليل البيانات ذات الصلة، واستكمال التقييمات اللازمة، والبدء في صياغة الخطة في النظام. ويجب إكمال عملية الإعداد في غضون 60 يوم عمل بدءًا من اليوم للوصول إلى نموذج إعداد خطة الامتثال، ",
                MessageBodyEn = "You must collect and analyze relevant data, complete the necessary assessments, and begin drafting the plan in the system. The preparation process must be completed within 20 business days from today to access the compliance plan preparation form.",
                ActionUrl = "/",
            },
            new ComplianceNotificationMassage()
            {
                Id = 15,
                Role = "ComplianceSpecialist",
                MessageType = "info",
                MessageTitleAR = "يمكنك استئناف تحرير خطتك واستكمالها في أي وقت قبل الموعد النهائي",
                MessageTitleEn = "You can resume editing and completing your plan at any time before the deadline.",
                MessageBodyAR = "قبل الموعد النهائي. يرجى التأكد من الانتهاء من المسودة وإرسالها في غضون الإطار الزمني المخصص وهو 60 يومًا للوصول إلى مسودتك ومواصلة العمل عليها، انقر فوق الرابط",
                MessageBodyEn = "Before the deadline. Please ensure you complete and submit your draft within the allotted 60-day timeframe. To access your draft and continue working on it, click the link.",
                ActionUrl = "/",
            },
            new ComplianceNotificationMassage()
            {
                Id = 16,
                Role = "ComplianceSpecialist",
                MessageType = "warning",
                MessageTitleAR = "هذا تذكير نهائي بأن الموعد النهائي لتقديم خطة الامتثال السنوية لا يزال على بعد 5 أيام فقط.",
                MessageTitleEn = "This is a final reminder that the deadline for submitting your annual compliance plan is still just 5 days away.",
                MessageBodyAR = "يرجى التأكد من إكمال جميع الخطوات المطلوبة، وتقديم الخطة في الوقت المحدد يعد تقديمك في الوقت المناسب أمرًا بالغ الأهمية لتحقيق أهداف الامتثال\r\nإذا كنت بحاجة إلى مساعدة، يرجى الاتصال بمديرك على الفور للحصول على الخطة في الرابط ادناه",
                MessageBodyEn = "Please ensure you complete all required steps and submit the plan on time. Your timely submission is critical to achieving compliance goals. If you need assistance, please contact your manager immediately to obtain the plan at the link below.",
                ActionUrl = "/",
            },
            new ComplianceNotificationMassage()
            {
                Id = 17,
                Role = "ComplianceSpecialist",
                MessageType = "error",
                MessageTitleAR = "هذا تذكير نهائي بأن الموعد النهائي لتقديم خطة الامتثال السنوية لا يزال على بعد 3 أيام فقط.",
                MessageTitleEn = "This is a final reminder that the deadline for submitting your annual compliance plan is still just 3 days away.",
                MessageBodyAR = "يرجى التأكد من إكمال جميع الخطوات المطلوبة، وتقديم الخطة في الوقت المحدد يعد تقديمك في الوقت المناسب أمرًا بالغ الأهمية لتحقيق أهداف الامتثال\r\nإذا كنت بحاجة إلى مساعدة، يرجى الاتصال بمديرك على الفور للحصول على الخطة في الرابط ادناه",
                MessageBodyEn = "Please ensure you complete all required steps and submit the plan on time. Your timely submission is critical to achieving compliance goals. If you need assistance, please contact your manager immediately to obtain the plan at the link below.",
                ActionUrl = "/",
            },
            new ComplianceNotificationMassage()
            {
                Id = 18,
                Role = "ComplianceSpecialist",
                MessageType = "error",
                MessageTitleAR = "نأسف لإبلاغك بأن تقديم خطة الامتثال السنوية لم يكتمل في الإطار الزمني المحدد لذا سيتم تصعيد الأمر للمدير العام.",
                MessageTitleEn = "We regret to inform you that the submission of the annual compliance plan was not completed within the specified timeframe, so the matter will be escalated to the General Manager.",
                MessageBodyAR = "يرجى التأكد من إكمال جميع الخطوات المطلوبة، وتقديم الخطة في الوقت المحدد يعد تقديمك في الوقت المناسب أمرًا بالغ الأهمية لتحقيق أهداف الامتثال\r\nإذا كنت بحاجة إلى مساعدة، يرجى الاتصال بمديرك على الفور للحصول على الخطة في الرابط ادناه",
                MessageBodyEn = "Please ensure you complete all required steps and submit the plan on time. Your timely submission is critical to achieving compliance goals. If you need assistance, please contact your manager immediately to obtain the plan at the link below.",
                ActionUrl = "/",
            },
            new ComplianceNotificationMassage()
            {
                Id = 19,
                Role = "ComplianceSpecialist",
                MessageType = "info",
                MessageTitleAR = "حالة مراجعة خطة الزيارات",
                MessageTitleEn = "Visit Plan Review Status",
                MessageBodyAR = "جاري المراجعة الأن من قبل المدير المباشر نشكركم لإرسال الخطة ",
                MessageBodyEn = "The plan is currently being reviewed by the direct manager. Thank you for submitting the plan.",
                ActionUrl = "/",
            },
            new ComplianceNotificationMassage()
            {
                Id = 20,
                Role = "ComplianceSpecialist",
                MessageType = "success",
                MessageTitleAR = "تمت الموافقة على الخطة من قبل مدير الادارة",
                MessageTitleEn = "The plan has been approved by the Compliance Manager.",
                MessageBodyAR = "",
                MessageBodyEn = "",
                ActionUrl = "/",
            },
            new ComplianceNotificationMassage()
            {
                Id = 21,
                Role = "ComplianceSpecialist",
                MessageType = "success",
                MessageTitleAR = "تمت الموافقة على الخطة من قبل مدير عام مراقبة الالتزام",
                MessageTitleEn = "The plan was approved by the Performance Monitoring Manager.",
                MessageBodyAR = "",
                MessageBodyEn = "",
                ActionUrl = "/",
            },
            new ComplianceNotificationMassage()
            {
                Id = 22,
                Role = "ComplianceSpecialist",
                MessageType = "info",
                MessageTitleAR = "حالة مراجعة خطة الزيارات",
                MessageTitleEn = "Visit Plan Review Status",
                MessageBodyAR = "جاري المراجعة الأن من قبل المدير العام لمراقبة الاداء نشكركم لإرسال الخطة ",
                MessageBodyEn = "The plan is currently being reviewed by the Performance Monitoring Manager.. Thank you for submitting the plan.",
                ActionUrl = "/",
            },
            new ComplianceNotificationMassage()
            {
                Id = 23,
                Role = "ComplianceSpecialist",
                MessageType = "success",
                MessageTitleAR = " تمت اعادة الخطة من قبل مدير الادارة ",
                MessageTitleEn = "The plan has been Returned by the Compliance Manager and .",
                MessageBodyAR = " وسبب الارجاع {{ReturnReason}}",
                MessageBodyEn = "Return reason is {{ReturnReason}}",
                ActionUrl = "/",
            },
            new ComplianceNotificationMassage()
            {
                Id = 24,
                Role = "ComplianceSpecialist",
                MessageType = "success",
                MessageTitleAR = "تمت اعادة الخطة من قبل مدير عام مراقبة الالتزام  ",
                MessageTitleEn = "The plan has been Returned by the Performance Monitoring Manager",
                MessageBodyAR = " وسبب الارجاع {{ReturnReason}}",
                MessageBodyEn = "Return reason is {{ReturnReason}}.",
                ActionUrl = "/",
            },
            #endregion

            #region Phase 2

            new ComplianceNotificationMassage()
            {
                Id = 25,
                Role = "ComplianceManager",
                MessageType = "info",
                MessageTitleAR = "تذكير بجدولة الزيارات الربع سنوية",
                MessageTitleEn = "Quarterly Visit Scheduling Reminder",
                MessageBodyAR = "حان الوقت لجدولة زيارات لـ {QuarterName}. يرجى تحديد تواريخ الزيارات المعلقة في خطة الانتقال السنوية.",
                MessageBodyEn = "It's time to schedule visits for {QuarterName}. Please indicate the dates of your pending visits in your annual transition plan.",
                ActionUrl = "/",
            },
            new ComplianceNotificationMassage()
            {
                Id = 26,
                Role = "ComplianceManager",
                MessageType = "info",
                MessageTitleAR = "تذكير بتعيين فريق للزيارة",
                MessageTitleEn = "Reminder to appoint a team for the visit",
                MessageBodyAR = "الزيارة القادمة لـ {LicenseeName} في {VisitDate} وفقًا لخطة الامتثال السنوية. تحقق من بريدك الإلكتروني لتعيين فريق.",
                MessageBodyEn = "{LicenseeName}'s next visit is on {VisitDate} according to the annual compliance plan. Check your email for team assignment.",
                ActionUrl = "/",
            },
            new ComplianceNotificationMassage()
            {
                Id = 27,
                Role = "ComplianceManager",
                MessageType = "info",
                MessageTitleAR = "لا يتوفر اي عضو فريق للزيارة ",
                MessageTitleEn = "No team member available for visit",
                MessageBodyAR = " تم تحديد تضارب في المصالح بالنسبة لـ {LicenseeName} فيما يتعلق بزيارة {SpecialistName} في [تاريخ الزيارة]. اقترح النظام عضوًا بديلاً في الفريق.\r\nيرجى مراجعة المهمة وإكمالها.",
                MessageBodyEn = "A conflict of interest was identified for {SpecialistName} regarding {LicenseeName}'s visit on [visit date]. The system has suggested an alternative team member.\r\nPlease review and complete the task.",
                ActionUrl = "/",
            },
            new ComplianceNotificationMassage()
            {
                Id = 28,
                Role = "ComplianceManager",
                MessageType = "info",
                MessageTitleAR = "لا يتوفر اي عضو فريق للزيارة ",
                MessageTitleEn = "No team member available for visit",
                MessageBodyAR = ":تاريخ الزيارة: {VisitDate} .\r\nاسم المرخص له: {LicenseeName}.\r\n أو توجد تعارضات{Reason}. ",
                MessageBodyEn = "Date of visit: {VisitDate}.\r\nName of licensee: {LicenseeName}.\r\nReason for shortage: {Reason}.",
                ActionUrl = "/",
            },
            new ComplianceNotificationMassage()
            {
                Id = 29,
                Role = "ComplianceManager",
                MessageType = "error",
                MessageTitleAR = "يوجد هناك تضارب في تعيينك ضمن الفريق وبالتالي سيتم استبعادك من الفريق.",
                MessageTitleEn = "There is a conflict in your assignment to the team and therefore you will be removed from the team.",
                MessageBodyAR = "والسبب {Reason}",
                MessageBodyEn = "The reason is {Reason}.",
                ActionUrl = "/",
            },
            
            new ComplianceNotificationMassage()
            {
                Id = 30,
                Role = "ComplianceSpecialist",
                MessageType = "info",
                MessageTitleAR = "لقد تم تعيينك في الزيارة {VisitDate} تأكد من ارسال نماذج الإفصاح خلال يومين ",
                MessageTitleEn = "You have been assigned to {VisitDate}. Please ensure you submit your disclosure forms within 2 days.",
                MessageBodyAR = "لقد تم تعيينك في الزيارة {VisitDate} يرجي العلم بان المدة المحددة لتحميل النماذج وارساله لنا في خلال يومين لتحميل النموذج في الرابط ادناه",
                MessageBodyEn = "You have been appointed for visit {VisitDate} Please note that the time limit for downloading the forms and sending them to us is two days. To download the form, use the link below.",
                ActionUrl = "/",
            },
            new ComplianceNotificationMassage()
            {
                Id = 31,
                Role = "ComplianceSpecialist",
                MessageType = "info",
                MessageTitleAR = "تذكير بجدولة الزيارات الربع سنوية",
                MessageTitleEn = "Quarterly Visit Scheduling Reminder",
                MessageBodyAR = "حان الوقت لجدولة زيارات لـ {QuarterName}. يرجى تحديد تواريخ الزيارات المعلقة في خطة الانتقال السنوية.",
                MessageBodyEn = "It's time to schedule visits for {QuarterName}. Please indicate the dates of your pending visits in your annual transition plan.",
                ActionUrl = "/",
            },

            
            #endregion

        });

    }
}
