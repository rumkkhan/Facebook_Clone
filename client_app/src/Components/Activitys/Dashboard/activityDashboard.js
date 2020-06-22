import React from 'react';
import { Grid, List } from 'semantic-ui-react';
import ActivityList from './activityList';
import ActivityDetails from '../Details/activityDetails';
import ActivityForm from '../ActivityForm/activityForm';

function ActivityDashboard(props) {
    let activity =props.activity.Activities

   return (
       <Grid style={{marginTop:"50px"}}>
           <Grid.Column width={10}>
             <ActivityList activity={activity}/>
           </Grid.Column>
           <Grid.Column width={6}>
               <ActivityDetails />
               <ActivityForm />
           </Grid.Column>
       </Grid>
   )
}
export default ActivityDashboard;
