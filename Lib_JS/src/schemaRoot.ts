import {EntitySchema} from "./entitySchema"
import {RelationSchema} from "./relationSchema"

export class SchemaRoot {

  public descriptionFormat: string = '';

  public timestampUtc: string = '';
  public semanticVersion: string = '';

  public entities: EntitySchema[] = [];

  public relations: RelationSchema[] = [];

}
