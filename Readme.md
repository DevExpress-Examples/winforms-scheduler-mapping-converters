<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128636538/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T497864)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Scheduler - Mapping converters

This example creates [mapping converters](https://docs.devexpress.com/WindowsForms/118437/controls-and-libraries/scheduler/data-binding/mappings/mapping-converters) that implement custom mapping logic. Mapping converters allow you to easily change the format in which data is stored, and perform additional actions before data is saved or loaded.

```csharp
schedulerStorage1.Appointments.Mappings.LabelConverter = new MappingConverterLabel(schedulerStorage1);
schedulerStorage1.Appointments.Mappings.LabelConversionBehavior = MappingConversionBehavior.InPlaceOfMapping;
schedulerStorage1.Appointments.Mappings.ReminderInfoConverter = new MappingConverterReminderInfo(schedulerStorage1);
schedulerStorage1.Appointments.Mappings.ReminderInfoConversionBehavior = MappingConversionBehavior.BetweenMappingAndProperty;
schedulerStorage1.Appointments.Mappings.StartConverter = new MappingConverterStart();
schedulerStorage1.Appointments.Mappings.StartConversionBehavior = MappingConversionBehavior.InPlaceOfMapping;
schedulerStorage1.Appointments.Mappings.EndConverter = new MappingConverterEnd();
schedulerStorage1.Appointments.Mappings.EndConversionBehavior = MappingConversionBehavior.InPlaceOfMapping;
```


## Files to Review

* [Form1.cs](./CS/SchedulerMappingConverterExample/Form1.cs) (VB: [Form1.vb](./VB/SchedulerMappingConverterExample/Form1.vb))
* [MappingConverterEnd.cs](./CS/SchedulerMappingConverterExample/MappingConverterEnd.cs) (VB: [MappingConverterEnd.vb](./VB/SchedulerMappingConverterExample/MappingConverterEnd.vb))
* [MappingConverterLabel.cs](./CS/SchedulerMappingConverterExample/MappingConverterLabel.cs) (VB: [MappingConverterLabel.vb](./VB/SchedulerMappingConverterExample/MappingConverterLabel.vb))
* [MappingConverterReminderInfo.cs](./CS/SchedulerMappingConverterExample/MappingConverterReminderInfo.cs) (VB: [MappingConverterReminderInfo.vb](./VB/SchedulerMappingConverterExample/MappingConverterReminderInfo.vb))
* [MappingConverterStart.cs](./CS/SchedulerMappingConverterExample/MappingConverterStart.cs) (VB: [MappingConverterStart.vb](./VB/SchedulerMappingConverterExample/MappingConverterStart.vb))


## Documentation

* [Mapping Converters](https://docs.devexpress.com/WindowsForms/118437/controls-and-libraries/scheduler/data-binding/mappings/mapping-converters)
* [Mappings - Overview](https://docs.devexpress.com/WindowsForms/15468/controls-and-libraries/scheduler/data-binding/mappings)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-scheduler-mapping-converters&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-scheduler-mapping-converters&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
