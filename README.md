# How to display more data in the tooltip of WPF Chart (SfChart)?

[WPF Chart](https://www.syncfusion.com/wpf-controls/charts) provides the support to display the needed information from its model of populated items source along with Tooltip UI customization with the help of [TooltipTemplate](https://help.syncfusion.com/wpf/charts/interactive-features/tooltip#customizing-the-appearance) in the chart series as shown in the following code example.

Here, display the both country's name and its population details in the tooltip. By default, it displays the corresponding y-axis value of that segment.

```
<Window.DataContext>
        <local:ViewModel/>
</Window.DataContext>
<Window.Resources>
      <DataTemplate x:Key="tooltipTemplate">
           <StackPanel Orientation="Horizontal">
               <!--Template element has DataContext as its Segment named Item. From it, you can access the correponding Model-->
               <TextBlock  FontFamily="Segoe UI"  Foreground="White">
                   <Run Text="{Binding Item.Country}"/>
                   <Run Text=":"/>  
                   <Run Text="{Binding Item.Population}"/>
               </TextBlock>
           </StackPanel>
      </DataTemplate>
</Window.Resources>
<StackPanel>
    <syncfusion:SfChart Header="Population growth" Width="353" Height="298">
        <syncfusion:SfChart.PrimaryAxis>
            <syncfusion:CategoryAxis/>
        </syncfusion:SfChart.PrimaryAxis>
        <syncfusion:SfChart.SecondaryAxis>
            <syncfusion:NumericalAxis/>
        </syncfusion:SfChart.SecondaryAxis>
        <syncfusion:ColumnSeries 
                         ItemsSource="{Binding Data}"
                         XBindingPath="Country"
                         YBindingPath="Population"
                         ShowTooltip="True"
                         TooltipTemplate="{StaticResource tooltipTemplate}"/>
    </syncfusion:SfChart>
</StackPanel>
```

## Output:

![Tooltip with more data in WPF chart](https://github.com/SyncfusionExamples/How-to-make-the-tooltip-to-display-any-other-value-from-the-underlying-model-in-WPF-Charts/blob/main/WPF_Chart_Tooltip_Multiple_Values.gif)

KB article - [How to make the tooltip to display any other value from the underlying model in WPF Chart (SfChart)?](https://www.syncfusion.com/kb/5231/how-to-display-more-data-in-the-tooltip-of-wpf-chart-sfchart)

## See also

[How to display the tooltip when the mouse is in any region of the FastLineBitmapSeries in WPF Charts](https://www.syncfusion.com/kb/10921/how-to-display-the-tooltip-when-the-mouse-is-in-any-region-of-the-fastlinebitmapseries-in)

[How to customize WPF Charts tooltip](https://www.syncfusion.com/kb/10723/how-to-customize-the-tooltip-in-chart)

[How to set the duration for chart tooltip](https://www.syncfusion.com/kb/5474/how-to-set-the-duration-for-wpf-chart-sfchart-tooltip)
