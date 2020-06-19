import React from 'react';
import ActivityDashboard from './Dashboard/activityDashboard';

 const ActivityContainer =(props)  =>{

    return (
        <div>
          
            <ActivityDashboard {...props} />
        </div>
    )
}

export default ActivityContainer
