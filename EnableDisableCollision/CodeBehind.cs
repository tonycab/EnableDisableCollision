using ABB.Robotics.Math;
using ABB.Robotics.RobotStudio;
using ABB.Robotics.RobotStudio.Stations;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace EnableDisableCollision
{
    /// <summary>
    /// Code-behind class for the EnableDisableCollision Smart Component.
    /// </summary>
    /// <remarks>
    /// The code-behind class should be seen as a service provider used by the 
    /// Smart Component runtime. Only one instance of the code-behind class
    /// is created, regardless of how many instances there are of the associated
    /// Smart Component.
    /// Therefore, the code-behind class should not store any state information.
    /// Instead, use the SmartComponent.StateCache collection.
    /// </remarks>
    public class CodeBehind : SmartComponentCodeBehind
    {

        CollisionSet collisionSet1;
        CollisionSet collisionSet2;
        CollisionSet collisionSet3;
        CollisionSet collisionSet4;
        CollisionSet collisionSet5;
        CollisionSet collisionSet6;



        /// <summary>
        /// Called when the value of a dynamic property value has changed.
        /// </summary>
        /// <param name="component"> Component that owns the changed property. </param>
        /// <param name="changedProperty"> Changed property. </param>
        /// <param name="oldValue"> Previous value of the changed property. </param>
        public override void OnPropertyValueChanged(SmartComponent component, DynamicProperty changedProperty, Object oldValue)
        {

          
                try
                {
                    collisionSet1 = (CollisionSet)component.Properties["Collision1"].Value;
                }
                catch { }

                try
                {
                    collisionSet2 = (CollisionSet)component.Properties["Collision2"].Value;
                }
                catch { }
                try
                {
                    collisionSet3 = (CollisionSet)component.Properties["Collision3"].Value;
                }
                catch { }
                try
                {
                    collisionSet4 = (CollisionSet)component.Properties["Collision4"].Value;
                }
                catch { }
                try
                {
                    collisionSet5 = (CollisionSet)component.Properties["Collision5"].Value;
                }
                catch { }
                try
                {
                    collisionSet6 = (CollisionSet)component.Properties["Collision6"].Value;
                }
                catch { }

        }

        /// <summary>
        /// Called when the value of an I/O signal value has changed.
        /// </summary>
        /// <param name="component"> Component that owns the changed signal. </param>
        /// <param name="changedSignal"> Changed signal. </param>
        public override void OnIOSignalValueChanged(SmartComponent component, IOSignal changedSignal)
        {
            try
            {
                this.OnLoad(component);

                if (changedSignal.Name == "ToolCollisionEnable")
                {

                    if (collisionSet1 != null) collisionSet1.Active = false;
                    if (collisionSet2 != null) collisionSet2.Active = false;
                    if (collisionSet3 != null) collisionSet3.Active = false;
                    if (collisionSet4 != null) collisionSet4.Active = false;
                    if (collisionSet5 != null) collisionSet5.Active = false;
                    if (collisionSet6 != null) collisionSet6.Active = false;



                    if ((uint)component.IOSignals["ToolCollisionEnable"].Value == 1)
                    {
                        collisionSet1.Active = true;

                    }
                    if ((uint)component.IOSignals["ToolCollisionEnable"].Value == 2)
                    {
                        collisionSet2.Active = true;

                    }
                    if ((uint)component.IOSignals["ToolCollisionEnable"].Value == 3)
                    {
                        collisionSet3.Active = true;
                    }
                    if ((uint)component.IOSignals["ToolCollisionEnable"].Value == 4)
                    {
                        collisionSet4.Active = true;
                    }
                    if ((uint)component.IOSignals["ToolCollisionEnable"].Value == 5)
                    {
                        collisionSet5.Active = true;
                    }
                    if ((uint)component.IOSignals["ToolCollisionEnable"].Value == 6)
                    {
                        collisionSet6.Active = true;
                    }

                    Logger.AddMessage(new LogMessage("CollisionSet " + (uint)component.IOSignals["ToolCollisionEnable"].Value + " : " + collisionSet1.Active));
                }
            }
            catch (Exception ex) 
            {
            }
        }
        public override void OnLoad(SmartComponent component)
        {
            base.OnLoad(component);
      
            try
            {
                collisionSet1 = (CollisionSet)component.Properties["Collision1"].Value;
            }
            catch { }

            try
            {
                collisionSet2 = (CollisionSet)component.Properties["Collision2"].Value;
            }
            catch { }
            try
            {
                collisionSet3 = (CollisionSet)component.Properties["Collision3"].Value;
            }
            catch { }
            try
            {
                collisionSet4 = (CollisionSet)component.Properties["Collision4"].Value;
            }
            catch { }
            try
            {
                collisionSet5 = (CollisionSet)component.Properties["Collision5"].Value;
            }
            catch { }
            try
            {
                collisionSet6 = (CollisionSet)component.Properties["Collision6"].Value;
            }
            catch { }

            base.OnLoad(component);
        }


        /// <summary>
        /// Called during simulation.
        /// </summary>
        /// <param name="component"> Simulated component. </param>
        /// <param name="simulationTime"> Time (in ms) for the current simulation step. </param>
        /// <param name="previousTime"> Time (in ms) for the previous simulation step. </param>
        /// <remarks>
        /// For this method to be called, the component must be marked with
        /// simulate="true" in the xml file.
        /// </remarks>
        public override void OnSimulationStep(SmartComponent component, double simulationTime, double previousTime)
        {

        }
    }
}
