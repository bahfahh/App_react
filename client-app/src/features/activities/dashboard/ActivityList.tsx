import * as React from 'react';
import { Activity } from '../../../model/activity';
import { Button, Item, ItemContent, Label } from 'semantic-ui-react';
interface Props {
    activities: Activity[];
}
export default function ActivityList({ activities }: Props) {
    return (
        <>
            <Item.Group divided>
                {activities.map(activity => (
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
                                <Label basic content={activity.category} />
                            </Item.Extra>

                        </Item.Content>
                    </Item>
                ))
                }
            </Item.Group>
        </>
    );
}