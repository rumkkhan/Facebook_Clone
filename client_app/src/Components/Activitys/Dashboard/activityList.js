import React from 'react'
import {Item,Image,Header, Button, Label, Segment} from 'semantic-ui-react';

 function ActivityList({activity}) {
    return (
        <Segment clearing>
        <Item.Group divided>
            {
                activity.map(activity => (
                    <Item key={activity.id}>
                    <Item.Content>
                <Item.Header as='a'>{activity.title}</Item.Header>
                        <Item.Meta>{activity.date}</Item.Meta>
                        <Item.Description>
                            <div>{activity.description}</div>
                              <div>{activity.city},{activity.venue}</div>
                        </Item.Description>
                        <Item.Extra>
                            <Button floated='right' content='View' color='blue' />
                            <Label basic content='Category'/>
                        </Item.Extra>
                    </Item.Content>
                </Item>
                ))
            }
            
        </Item.Group>
        </Segment>
 
    )
}
export default ActivityList;