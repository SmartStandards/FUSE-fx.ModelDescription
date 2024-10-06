import { EntitySchema } from './entitySchema';
import { IndexSchema } from './indexSchema';

export function matchOnPrimaryKeyIndex(o1: any, o2: any, entitySchema: EntitySchema): boolean {
  const primaryKeyIndex: IndexSchema | undefined = entitySchema.indices.find(
    (i) => i.name == entitySchema.primaryKeyIndexName,
  );
  if (!primaryKeyIndex) return false;
  return matchOnIndex(o1, o2, primaryKeyIndex);
}
export function matchOnIndex(o1: any, o2: any, primaryKeyIndex: IndexSchema): boolean {
  for (let p of primaryKeyIndex.memberFieldNames) {
    if (!Object.keys(o1).includes(p)) return false;
    if (!Object.keys(o2).includes(p)) return false;
    const p1: any = o1[p];
    const p2: any = o2[p];
    if (!(p1 == p2)) return false;
  }
  return true;
}
